namespace ExportSQL
{
    partial class WizardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardForm));
            this.wizardControl = new DevExpress.XtraWizard.WizardControl();
            this.welcomePage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.sourceTypePage = new DevExpress.XtraWizard.WizardPage();
            this.sourceTypeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.completionPage = new DevExpress.XtraWizard.CompletionWizardPage();
            this.INDESourcePage = new DevExpress.XtraWizard.WizardPage();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.INDEBuildFile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.otherSourcePage = new DevExpress.XtraWizard.WizardPage();
            this.OtherText = new DevExpress.XtraEditors.MemoEdit();
            this.objTypesPage = new DevExpress.XtraWizard.WizardPage();
            this.allCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.triggerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.functionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.procedureCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.viewCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.saveTypePage = new DevExpress.XtraWizard.WizardPage();
            this.saveModeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.savePathPage = new DevExpress.XtraWizard.WizardPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.savePath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.progressPage = new DevExpress.XtraWizard.WizardPage();
            this.progressLabel = new DevExpress.XtraEditors.LabelControl();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.endPage = new DevExpress.XtraWizard.WizardPage();
            this.restartButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dataBaseTypePage = new DevExpress.XtraWizard.WizardPage();
            this.dataBaseTypeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.sourceTypePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTypeRadioGroup.Properties)).BeginInit();
            this.INDESourcePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.INDEBuildFile.Properties)).BeginInit();
            this.otherSourcePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherText.Properties)).BeginInit();
            this.objTypesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckEdit.Properties)).BeginInit();
            this.saveTypePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveModeRadioGroup.Properties)).BeginInit();
            this.savePathPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savePath.Properties)).BeginInit();
            this.progressPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            this.endPage.SuspendLayout();
            this.dataBaseTypePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseTypeRadioGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.CancelText = "Esci";
            this.wizardControl.Controls.Add(this.welcomePage);
            this.wizardControl.Controls.Add(this.sourceTypePage);
            this.wizardControl.Controls.Add(this.completionPage);
            this.wizardControl.Controls.Add(this.INDESourcePage);
            this.wizardControl.Controls.Add(this.otherSourcePage);
            this.wizardControl.Controls.Add(this.objTypesPage);
            this.wizardControl.Controls.Add(this.saveTypePage);
            this.wizardControl.Controls.Add(this.savePathPage);
            this.wizardControl.Controls.Add(this.progressPage);
            this.wizardControl.Controls.Add(this.endPage);
            this.wizardControl.Controls.Add(this.dataBaseTypePage);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.HelpText = "&Aiuto";
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.NextText = "&Avanti >";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomePage,
            this.sourceTypePage,
            this.INDESourcePage,
            this.dataBaseTypePage,
            this.otherSourcePage,
            this.objTypesPage,
            this.saveTypePage,
            this.savePathPage,
            this.progressPage,
            this.endPage,
            this.completionPage});
            this.wizardControl.PreviousText = "< &Indietro";
            this.wizardControl.Size = new System.Drawing.Size(584, 364);
            this.wizardControl.Text = "Wizard Export SQL";
            this.wizardControl.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl1_SelectedPageChanged);
            this.wizardControl.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            this.wizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_CancelClick);
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            // 
            // welcomePage
            // 
            this.welcomePage.IntroductionText = "Trasforma il file ddl di Inde in un comodo script SQL";
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.ProceedText = "Per procedere, clicca Avanti";
            this.welcomePage.Size = new System.Drawing.Size(367, 231);
            this.welcomePage.Text = "Benvenuto!";
            // 
            // sourceTypePage
            // 
            this.sourceTypePage.Controls.Add(this.sourceTypeRadioGroup);
            this.sourceTypePage.Controls.Add(this.labelControl1);
            this.sourceTypePage.DescriptionText = "Selezionare il tipo di sorgente che si vuole utilizzare";
            this.sourceTypePage.Name = "sourceTypePage";
            this.sourceTypePage.Size = new System.Drawing.Size(552, 219);
            this.sourceTypePage.Text = "Tipo Sorgente";
            // 
            // sourceTypeRadioGroup
            // 
            this.sourceTypeRadioGroup.EditValue = 0;
            this.sourceTypeRadioGroup.Location = new System.Drawing.Point(21, 49);
            this.sourceTypeRadioGroup.Name = "sourceTypeRadioGroup";
            this.sourceTypeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Build INDE"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Altro")});
            this.sourceTypeRadioGroup.Size = new System.Drawing.Size(144, 47);
            this.sourceTypeRadioGroup.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tipo sorgente:";
            // 
            // completionPage
            // 
            this.completionPage.Name = "completionPage";
            this.completionPage.Size = new System.Drawing.Size(367, 231);
            // 
            // INDESourcePage
            // 
            this.INDESourcePage.Controls.Add(this.simpleButton1);
            this.INDESourcePage.Controls.Add(this.INDEBuildFile);
            this.INDESourcePage.Controls.Add(this.labelControl2);
            this.INDESourcePage.DescriptionText = "Selezionare il file di build INDE che si vuole utilizzare";
            this.INDESourcePage.Name = "INDESourcePage";
            this.INDESourcePage.Size = new System.Drawing.Size(552, 219);
            this.INDESourcePage.Text = "Build INDE";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(458, 73);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Sfoglia";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // INDEBuildFile
            // 
            this.INDEBuildFile.AllowDrop = true;
            this.INDEBuildFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.INDEBuildFile.Location = new System.Drawing.Point(22, 47);
            this.INDEBuildFile.Name = "INDEBuildFile";
            this.INDEBuildFile.Size = new System.Drawing.Size(527, 20);
            this.INDEBuildFile.TabIndex = 1;
            this.INDEBuildFile.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            this.INDEBuildFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.INDEBuildFile_DragDrop);
            this.INDEBuildFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.INDEBuildFile_DragEnter);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Build INDE:";
            // 
            // otherSourcePage
            // 
            this.otherSourcePage.Controls.Add(this.OtherText);
            this.otherSourcePage.DescriptionText = "Qui puoi inserire qualsiasi testo manualmente";
            this.otherSourcePage.Name = "otherSourcePage";
            this.otherSourcePage.Size = new System.Drawing.Size(552, 219);
            this.otherSourcePage.Text = "Altro sorgente";
            // 
            // OtherText
            // 
            this.OtherText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OtherText.EditValue = "Qui puoi inserire qualsiasi testo...";
            this.OtherText.Location = new System.Drawing.Point(0, 0);
            this.OtherText.Name = "OtherText";
            this.OtherText.Size = new System.Drawing.Size(552, 219);
            this.OtherText.TabIndex = 2;
            // 
            // objTypesPage
            // 
            this.objTypesPage.Controls.Add(this.allCheckEdit);
            this.objTypesPage.Controls.Add(this.triggerCheckEdit);
            this.objTypesPage.Controls.Add(this.functionCheckEdit);
            this.objTypesPage.Controls.Add(this.procedureCheckEdit);
            this.objTypesPage.Controls.Add(this.viewCheckEdit);
            this.objTypesPage.Controls.Add(this.labelControl3);
            this.objTypesPage.DescriptionText = "Selezionare i tipi di oggetti che si vuole esportare";
            this.objTypesPage.Name = "objTypesPage";
            this.objTypesPage.Size = new System.Drawing.Size(552, 219);
            this.objTypesPage.Text = "Tipi Oggetti";
            // 
            // allCheckEdit
            // 
            this.allCheckEdit.EditValue = true;
            this.allCheckEdit.Location = new System.Drawing.Point(29, 49);
            this.allCheckEdit.Name = "allCheckEdit";
            this.allCheckEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.allCheckEdit.Properties.Appearance.Options.UseFont = true;
            this.allCheckEdit.Properties.Caption = "Tutti";
            this.allCheckEdit.Size = new System.Drawing.Size(106, 19);
            this.allCheckEdit.TabIndex = 5;
            this.allCheckEdit.CheckedChanged += new System.EventHandler(this.checkEdit5_CheckedChanged);
            // 
            // triggerCheckEdit
            // 
            this.triggerCheckEdit.Enabled = false;
            this.triggerCheckEdit.Location = new System.Drawing.Point(29, 160);
            this.triggerCheckEdit.Name = "triggerCheckEdit";
            this.triggerCheckEdit.Properties.Caption = "Trigger";
            this.triggerCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.triggerCheckEdit.TabIndex = 4;
            // 
            // functionCheckEdit
            // 
            this.functionCheckEdit.Enabled = false;
            this.functionCheckEdit.Location = new System.Drawing.Point(29, 134);
            this.functionCheckEdit.Name = "functionCheckEdit";
            this.functionCheckEdit.Properties.Caption = "Funzioni";
            this.functionCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.functionCheckEdit.TabIndex = 3;
            // 
            // procedureCheckEdit
            // 
            this.procedureCheckEdit.Enabled = false;
            this.procedureCheckEdit.Location = new System.Drawing.Point(29, 108);
            this.procedureCheckEdit.Name = "procedureCheckEdit";
            this.procedureCheckEdit.Properties.Caption = "Procedure";
            this.procedureCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.procedureCheckEdit.TabIndex = 2;
            // 
            // viewCheckEdit
            // 
            this.viewCheckEdit.Enabled = false;
            this.viewCheckEdit.Location = new System.Drawing.Point(29, 82);
            this.viewCheckEdit.Name = "viewCheckEdit";
            this.viewCheckEdit.Properties.Caption = "Viste";
            this.viewCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.viewCheckEdit.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tipi oggetti:";
            // 
            // saveTypePage
            // 
            this.saveTypePage.Controls.Add(this.saveModeRadioGroup);
            this.saveTypePage.Controls.Add(this.labelControl4);
            this.saveTypePage.DescriptionText = "Selezionare la modalità di salvataggio che si desidera";
            this.saveTypePage.Name = "saveTypePage";
            this.saveTypePage.Size = new System.Drawing.Size(552, 219);
            this.saveTypePage.Text = "Modalità di Salvataggio";
            // 
            // saveModeRadioGroup
            // 
            this.saveModeRadioGroup.EditValue = 0;
            this.saveModeRadioGroup.Location = new System.Drawing.Point(26, 47);
            this.saveModeRadioGroup.Name = "saveModeRadioGroup";
            this.saveModeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Un singolo file per ciascun tipo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Un singolo file per ciascun oggetto, diviso in cartelle per ciascun tipo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Un file unico per tutti gli oggetti")});
            this.saveModeRadioGroup.Size = new System.Drawing.Size(402, 70);
            this.saveModeRadioGroup.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 19);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Modalità:";
            // 
            // savePathPage
            // 
            this.savePathPage.Controls.Add(this.simpleButton2);
            this.savePathPage.Controls.Add(this.savePath);
            this.savePathPage.Controls.Add(this.labelControl5);
            this.savePathPage.DescriptionText = "Selezionare il percorso dove si vuole salvare il risultato dell\'export";
            this.savePathPage.Name = "savePathPage";
            this.savePathPage.Size = new System.Drawing.Size(552, 219);
            this.savePathPage.Text = "Salvataggio";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Location = new System.Drawing.Point(458, 76);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Sfoglia";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // savePath
            // 
            this.savePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePath.Location = new System.Drawing.Point(25, 50);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(524, 20);
            this.savePath.TabIndex = 1;
            this.savePath.TextChanged += new System.EventHandler(this.textEdit2_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Percorso:";
            // 
            // progressPage
            // 
            this.progressPage.Controls.Add(this.progressLabel);
            this.progressPage.Controls.Add(this.marqueeProgressBarControl1);
            this.progressPage.DescriptionText = "Attendere durante l\'export";
            this.progressPage.Name = "progressPage";
            this.progressPage.Size = new System.Drawing.Size(552, 219);
            this.progressPage.Text = "Progresso";
            // 
            // progressLabel
            // 
            this.progressLabel.Location = new System.Drawing.Point(81, 69);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(107, 13);
            this.progressLabel.TabIndex = 1;
            this.progressLabel.Text = "Operazione in corso...";
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(81, 35);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(383, 28);
            this.marqueeProgressBarControl1.TabIndex = 0;
            // 
            // endPage
            // 
            this.endPage.Controls.Add(this.restartButton);
            this.endPage.Controls.Add(this.labelControl6);
            this.endPage.DescriptionText = "L\'operazione e\' finita";
            this.endPage.Name = "endPage";
            this.endPage.Size = new System.Drawing.Size(552, 219);
            this.endPage.Text = "Fine";
            // 
            // restartButton
            // 
            this.restartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restartButton.Location = new System.Drawing.Point(427, 193);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(122, 23);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Ritorna all\'inizio";
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(4, 17);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(183, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "L\'operazione è conclusa con successo.";
            // 
            // dataBaseTypePage
            // 
            this.dataBaseTypePage.Controls.Add(this.dataBaseTypeRadioGroup);
            this.dataBaseTypePage.Controls.Add(this.labelControl7);
            this.dataBaseTypePage.DescriptionText = "Non è stato possibile trovare il tipo di database automaticamente, selezionare il" +
    " tipo di database";
            this.dataBaseTypePage.Name = "dataBaseTypePage";
            this.dataBaseTypePage.Size = new System.Drawing.Size(552, 219);
            this.dataBaseTypePage.Text = "Tipo DataBase";
            // 
            // dataBaseTypeRadioGroup
            // 
            this.dataBaseTypeRadioGroup.EditValue = 1;
            this.dataBaseTypeRadioGroup.Location = new System.Drawing.Point(22, 50);
            this.dataBaseTypeRadioGroup.Name = "dataBaseTypeRadioGroup";
            this.dataBaseTypeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Oracle"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "SQL Server")});
            this.dataBaseTypeRadioGroup.Size = new System.Drawing.Size(121, 49);
            this.dataBaseTypeRadioGroup.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(3, 21);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Tipo DataBase:";
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.wizardControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "WizardForm";
            this.Text = "Export SQL";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.sourceTypePage.ResumeLayout(false);
            this.sourceTypePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceTypeRadioGroup.Properties)).EndInit();
            this.INDESourcePage.ResumeLayout(false);
            this.INDESourcePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.INDEBuildFile.Properties)).EndInit();
            this.otherSourcePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OtherText.Properties)).EndInit();
            this.objTypesPage.ResumeLayout(false);
            this.objTypesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triggerCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCheckEdit.Properties)).EndInit();
            this.saveTypePage.ResumeLayout(false);
            this.saveTypePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveModeRadioGroup.Properties)).EndInit();
            this.savePathPage.ResumeLayout(false);
            this.savePathPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savePath.Properties)).EndInit();
            this.progressPage.ResumeLayout(false);
            this.progressPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.endPage.ResumeLayout(false);
            this.endPage.PerformLayout();
            this.dataBaseTypePage.ResumeLayout(false);
            this.dataBaseTypePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseTypeRadioGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomePage;
        private DevExpress.XtraWizard.WizardPage sourceTypePage;
        private DevExpress.XtraWizard.CompletionWizardPage completionPage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup sourceTypeRadioGroup;
        private DevExpress.XtraWizard.WizardPage INDESourcePage;
        private DevExpress.XtraWizard.WizardPage otherSourcePage;
        private DevExpress.XtraWizard.WizardPage objTypesPage;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit INDEBuildFile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit OtherText;
        private DevExpress.XtraEditors.CheckEdit triggerCheckEdit;
        private DevExpress.XtraEditors.CheckEdit functionCheckEdit;
        private DevExpress.XtraEditors.CheckEdit procedureCheckEdit;
        private DevExpress.XtraEditors.CheckEdit viewCheckEdit;
        private DevExpress.XtraEditors.CheckEdit allCheckEdit;
        private DevExpress.XtraWizard.WizardPage saveTypePage;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.RadioGroup saveModeRadioGroup;
        private DevExpress.XtraWizard.WizardPage savePathPage;
        private DevExpress.XtraEditors.TextEdit savePath;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraWizard.WizardPage progressPage;
        private DevExpress.XtraWizard.WizardPage endPage;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton restartButton;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.LabelControl progressLabel;
        private DevExpress.XtraWizard.WizardPage dataBaseTypePage;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.RadioGroup dataBaseTypeRadioGroup;
    }
}

