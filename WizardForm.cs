namespace ExportSQL
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    using global::ExportSQL.Properties;
    using global::ExportSQL.Settings;

    public partial class WizardForm : Form
    {
        ExportSQL exp;

        public WizardForm()
        {
            this.InitializeComponent();
            this.InitializeComponentCustom();
        }

        /// <summary>
        /// Custom Initializations
        /// </summary>
        private void InitializeComponentCustom()
        {
            this.exp = new ExportSQL();
        }

        private void export()
        {
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            this.expButton.Visible = false;
            this.progressPanel.Visible = true;
            this.restartButton.Visible = false;
            this.progressBar1.Visible = true;
            if (this.oracleRadioButton.Checked)
            {
                this.exp.DbType = ExportSQL.DataBaseType.Oracle;
            }
            else
            {
                this.exp.DbType = ExportSQL.DataBaseType.SQLServer;
            }

            if (indeRadioButton.Checked)
            {
                this.exp.ReadIndeBuild(this.INDEBuildFile.Text);
            }
            else
            {
                this.exp.readOtherText(this.OtherText.Text);
            }
           

            if (this.viewCheckBox.Checked || this.allCheckBox.Checked)
            {
                this.progressLabel.Text = Resources.WizardForm_export_Estrazione_delle_viste;
                this.exp.ExtractViews();
            }

            if (this.procedureCheckBox.Checked || this.allCheckBox.Checked)
            {
                this.progressLabel.Text = Resources.WizardForm_export_Estrazione_delle_procedure;
                this.exp.ExtractProcedures();
            }

            if (this.funzionCheckBox.Checked || this.allCheckBox.Checked)
            {
                this.progressLabel.Text = Resources.WizardForm_export_Estrazione_delle_funzioni;
                this.exp.ExtractFunctions();
            }

            if (this.triggerCheckBox.Checked || this.allCheckBox.Checked)
            {
                this.progressLabel.Text = Resources.WizardForm_export_Estrazione_dei_trigger;
                this.exp.ExtractTriggers();
            }

            if (this.mod1RadioButton.Checked)
            {
                this.exp.Export(ExportSQL.SaveMode.SingleFile, this.destTextBox.Text);
            }
            else if (this.mod2RadioButton.Checked)
            {
                this.exp.Export(ExportSQL.SaveMode.SingleFilePerType, this.destTextBox.Text);
            }
            else
            {
                this.exp.Export(ExportSQL.SaveMode.SingleFilePerObject, this.destTextBox.Text);
            }

            this.progressLabel.Text = Resources.WizardForm_export_Salvataggio;
            
            this.progressLabel.Text = Resources.WizardForm_export_Operazione_completata_con_successo;
            this.progressBar1.Visible = false;

            this.restartButton.Visible = true;
        }

        

        
        private bool validate()
        {
            if (!this.allCheckBox.Checked &&
                !this.viewCheckBox.Checked &&
                !this.procedureCheckBox.Checked &&
                !this.funzionCheckBox.Checked &&
                !this.triggerCheckBox.Checked)
            {
                MessageBox.Show(
                    Resources.WizardForm_validate_Scegliere_almeno_un_tipo_di_oggetto_,
                    Resources.WizardForm_validate_Attenzione,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (indeRadioButton.Checked && !File.Exists(this.INDEBuildFile.Text))
            {
                MessageBox.Show(
                    Resources.WizardForm_validate_Scegliere_un_file_esistente_e_valido,
                    Resources.WizardForm_validate_Errore,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (!Directory.Exists(this.destTextBox.Text))
            {
                MessageBox.Show(
                    Resources.WizardForm_validate_Scegliere_una_cartella_esistente_e_valida,
                    Resources.WizardForm_validate_Errore,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = @"Build INDE (*.ddl)|*.ddl|Tutti i file (*.*)|*.*";
            fd.InitialDirectory = General.Default.DefaultInputFile;
            fd.Multiselect = false;
            fd.ValidateNames = true;

            fd.ShowDialog();
            if (!fd.FileName.Equals(string.Empty))
            {
                this.INDEBuildFile.Text = fd.FileName;
                this.destTextBox.Text = Path.GetDirectoryName(fd.FileName);
            }
        }


        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.Checked)
            {
                this.viewCheckBox.Checked = true;
                this.procedureCheckBox.Checked = true;
                this.funzionCheckBox.Checked = true;
                this.triggerCheckBox.Checked = true;
            }
            this.viewCheckBox.Enabled = !this.allCheckBox.Checked;
            this.procedureCheckBox.Enabled = !this.allCheckBox.Checked;
            this.funzionCheckBox.Enabled = !this.allCheckBox.Checked;
            this.triggerCheckBox.Enabled = !this.allCheckBox.Checked;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();

            fb.ShowNewFolderButton = true;

            fb.ShowDialog();
            if (!fb.SelectedPath.Equals(string.Empty))
            {
                this.destTextBox.Text = fb.SelectedPath;
            }
        }

        private void INDEBuildFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            } 
        }

        private void INDEBuildFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                this.INDEBuildFile.Text = files[0];
                this.destTextBox.Text = Path.GetDirectoryName(files[0]);
            }
        }

        private void WizardForm_Load(object sender, EventArgs e)
        {

        }

        private void expButton_Click(object sender, EventArgs e)
        {
            if (this.validate())
            {                
                this.export();
            }
        }

        private void indeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.OtherText.Visible = false;
            }
        }

        private void altroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.OtherText.Visible = true;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.progressPanel.Visible = false;
            this.expButton.Visible = true;
        }
    }
}
