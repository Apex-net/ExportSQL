using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraWizard;

namespace ExportSQL
{
    public partial class WizardForm : Form
    {
        ExportSQL exp;

        public WizardForm()
        {
            InitializeComponent();
            InitializeComponentCustom();
        }

        /// <summary>
        /// Custom Initializations
        /// </summary>
        private void InitializeComponentCustom()
        {
            exp = new ExportSQL();
        }

        private void export()
        {
            if (viewCheckEdit.Checked || allCheckEdit.Checked)
            {
                progressLabel.Text = "Estrazione delle viste...";
                exp.ExtractViews();
            }

            if (procedureCheckEdit.Checked || allCheckEdit.Checked)
            {
                progressLabel.Text = "Estrazione delle procedure...";
                exp.ExtractProcedures();
            }

            if (functionCheckEdit.Checked || allCheckEdit.Checked)
            {
                progressLabel.Text = "Estrazione delle funzioni...";
                exp.ExtractFunctions();
            }

            if (triggerCheckEdit.Checked || allCheckEdit.Checked)
            {
                progressLabel.Text = "Estrazione dei trigger...";
                exp.ExtractTriggers();
            }

            progressLabel.Text = "Salvataggio...";
            exp.Export((ExportSQL.SaveMode)saveModeRadioGroup.EditValue, savePath.Text);

            progressLabel.Text = "Fine.";
            wizardControl.SelectedPage = endPage;
        }

        private void wizardControl1_SelectedPageChanged(object sender, WizardPageChangedEventArgs e)
        {
            if (e.Page == INDESourcePage && INDEBuildFile.Text.Equals(string.Empty))
            {
                INDEBuildFile.Text = Settings.General.Default.DefaultInputFile;
            }

            if (e.Page == savePathPage && savePath.Text.Equals(string.Empty))
            {
                savePath.Text = Settings.General.Default.DefaultOutputPath;
            }

            if (e.Page == progressPage)
            {
                progressPage.AllowNext = false;
                progressPage.AllowBack = false;
                export();
            }

            if (e.Page == endPage)
            {
                endPage.AllowNext = false;
                endPage.AllowBack = false;
            }
        }

        private void wizardControl1_SelectedPageChanging(object sender, WizardPageChangingEventArgs e)
        {
            #region Forwards
            if (e.PrevPage == sourceTypePage && e.Direction == Direction.Forward)
            {
                ExportSQL.SourceType type = (ExportSQL.SourceType)sourceTypeRadioGroup.EditValue;
                switch (type)
                {
                    case ExportSQL.SourceType.Inde:
                        e.Page = INDESourcePage;
                        break;

                    case ExportSQL.SourceType.Other:
                        e.Page = otherSourcePage;
                        break;

                    default:
                        throw new NotSupportedException(String.Format("{0} is not a valid source type!", type));
                }
            }

            if (e.PrevPage == INDESourcePage && e.Direction == Direction.Forward)
            {
                exp.ReadIndeBuild(INDEBuildFile.Text);
                if (exp.DbType == ExportSQL.DataBaseType.Unknown)
                {
                    e.Page = dataBaseTypePage;
                }
                else
                {
                    e.Page = objTypesPage;
                }
            }

            if (e.PrevPage == otherSourcePage && e.Direction == Direction.Forward)
            {
                exp.readOtherText(OtherText.Text);
                e.Page = dataBaseTypePage;
            }

            if (e.PrevPage == dataBaseTypePage && e.Direction == Direction.Forward)
            {
                exp.DbType = (ExportSQL.DataBaseType)dataBaseTypeRadioGroup.EditValue;
                e.Page = objTypesPage;
            }
            #endregion

            #region Backwards
            if (e.PrevPage == otherSourcePage && e.Direction == Direction.Backward)
            {
                e.Page = sourceTypePage;
            }

            if (e.PrevPage == dataBaseTypePage && e.Direction == Direction.Backward)
            {
                e.Page = sourceTypePage;
            }

            if (e.PrevPage == objTypesPage && e.Direction == Direction.Backward)
            {
                e.Page = sourceTypePage;
            }
            #endregion
        }

        private void wizardControl_NextClick(object sender, WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == objTypesPage &&
                !allCheckEdit.Checked &&
                !viewCheckEdit.Checked &&
                !procedureCheckEdit.Checked &&
                !functionCheckEdit.Checked &&
                !triggerCheckEdit.Checked)
            {
                MessageBox.Show(
                    "Scegliere almeno un tipo di oggetto!",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                e.Handled = true;
            }

            if (e.Page == INDESourcePage && !File.Exists(INDEBuildFile.Text))
            {
                MessageBox.Show(
                    "Scegliere un file esistente e valido!",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Handled = true;
            }

            if (e.Page == savePathPage && !Directory.Exists(savePath.Text))
            {
                MessageBox.Show(
                    "Scegliere una cartella esistente e valida!",
                    "Errore",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                e.Handled = true;
            }
        }

        private void wizardControl_CancelClick(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = @"Build INDE (*.ddl)|*.ddl|Tutti i file (*.*)|*.*";
            fd.InitialDirectory = Settings.General.Default.DefaultInputFile;
            fd.Multiselect = false;
            fd.ValidateNames = true;

            fd.ShowDialog();
            if (!fd.FileName.Equals(string.Empty))
            {
                INDEBuildFile.Text = fd.FileName;
            }
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            INDESourcePage.AllowNext = !INDEBuildFile.Text.Equals(string.Empty);
        }

        private void textEdit2_TextChanged(object sender, EventArgs e)
        {
            savePathPage.AllowNext = !savePath.Text.Equals(string.Empty);
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            viewCheckEdit.Enabled = !allCheckEdit.Checked;
            procedureCheckEdit.Enabled = !allCheckEdit.Checked;
            functionCheckEdit.Enabled = !allCheckEdit.Checked;
            triggerCheckEdit.Enabled = !allCheckEdit.Checked;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();

            fb.ShowNewFolderButton = true;

            fb.ShowDialog();
            if (!fb.SelectedPath.Equals(string.Empty))
            {
                savePath.Text = fb.SelectedPath;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            InitializeComponentCustom();
            wizardControl.SelectedPage = welcomePage;
        }

        private void INDEBuildFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            } 
        }

        private void INDEBuildFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                INDEBuildFile.Text = files[0];
            }
        }
    }
}
