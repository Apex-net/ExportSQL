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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OtherText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.altroRadioButton = new System.Windows.Forms.RadioButton();
            this.indeRadioButton = new System.Windows.Forms.RadioButton();
            this.INDEBuildFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sqlServerRadioButton = new System.Windows.Forms.RadioButton();
            this.oracleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mod1RadioButton = new System.Windows.Forms.RadioButton();
            this.mod3RadioButton = new System.Windows.Forms.RadioButton();
            this.mod2RadioButton = new System.Windows.Forms.RadioButton();
            this.expButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.destTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.triggerCheckBox = new System.Windows.Forms.CheckBox();
            this.funzionCheckBox = new System.Windows.Forms.CheckBox();
            this.viewCheckBox = new System.Windows.Forms.CheckBox();
            this.procedureCheckBox = new System.Windows.Forms.CheckBox();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.restartButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.progressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OtherText);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.altroRadioButton);
            this.groupBox1.Controls.Add(this.indeRadioButton);
            this.groupBox1.Controls.Add(this.INDEBuildFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 102);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origine";
            // 
            // OtherText
            // 
            this.OtherText.Location = new System.Drawing.Point(122, 19);
            this.OtherText.Multiline = true;
            this.OtherText.Name = "OtherText";
            this.OtherText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OtherText.Size = new System.Drawing.Size(426, 64);
            this.OtherText.TabIndex = 54;
            this.OtherText.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(419, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Sfoglia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // altroRadioButton
            // 
            this.altroRadioButton.AutoSize = true;
            this.altroRadioButton.Location = new System.Drawing.Point(15, 46);
            this.altroRadioButton.Name = "altroRadioButton";
            this.altroRadioButton.Size = new System.Drawing.Size(46, 17);
            this.altroRadioButton.TabIndex = 1;
            this.altroRadioButton.Text = "Altro";
            this.altroRadioButton.UseVisualStyleBackColor = true;
            this.altroRadioButton.CheckedChanged += new System.EventHandler(this.altroRadioButton_CheckedChanged);
            // 
            // indeRadioButton
            // 
            this.indeRadioButton.AutoSize = true;
            this.indeRadioButton.Checked = true;
            this.indeRadioButton.Location = new System.Drawing.Point(15, 23);
            this.indeRadioButton.Name = "indeRadioButton";
            this.indeRadioButton.Size = new System.Drawing.Size(77, 17);
            this.indeRadioButton.TabIndex = 0;
            this.indeRadioButton.TabStop = true;
            this.indeRadioButton.Text = "Build INDE";
            this.indeRadioButton.UseVisualStyleBackColor = true;
            this.indeRadioButton.CheckedChanged += new System.EventHandler(this.indeRadioButton_CheckedChanged);
            // 
            // INDEBuildFile
            // 
            this.INDEBuildFile.AllowDrop = true;
            this.INDEBuildFile.Location = new System.Drawing.Point(122, 40);
            this.INDEBuildFile.Name = "INDEBuildFile";
            this.INDEBuildFile.Size = new System.Drawing.Size(289, 20);
            this.INDEBuildFile.TabIndex = 41;
            this.INDEBuildFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.INDEBuildFile_DragDrop);
            this.INDEBuildFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.INDEBuildFile_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sqlServerRadioButton);
            this.groupBox2.Controls.Add(this.oracleRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 94);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo database";
            // 
            // sqlServerRadioButton
            // 
            this.sqlServerRadioButton.AutoSize = true;
            this.sqlServerRadioButton.Location = new System.Drawing.Point(20, 42);
            this.sqlServerRadioButton.Name = "sqlServerRadioButton";
            this.sqlServerRadioButton.Size = new System.Drawing.Size(74, 17);
            this.sqlServerRadioButton.TabIndex = 2;
            this.sqlServerRadioButton.Text = "Sql Server";
            this.sqlServerRadioButton.UseVisualStyleBackColor = true;
            // 
            // oracleRadioButton
            // 
            this.oracleRadioButton.AutoSize = true;
            this.oracleRadioButton.Checked = true;
            this.oracleRadioButton.Location = new System.Drawing.Point(20, 19);
            this.oracleRadioButton.Name = "oracleRadioButton";
            this.oracleRadioButton.Size = new System.Drawing.Size(56, 17);
            this.oracleRadioButton.TabIndex = 1;
            this.oracleRadioButton.TabStop = true;
            this.oracleRadioButton.Text = "Oracle";
            this.oracleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mod1RadioButton);
            this.groupBox3.Controls.Add(this.mod3RadioButton);
            this.groupBox3.Controls.Add(this.mod2RadioButton);
            this.groupBox3.Location = new System.Drawing.Point(160, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 94);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modalità";
            // 
            // mod1RadioButton
            // 
            this.mod1RadioButton.AutoSize = true;
            this.mod1RadioButton.Checked = true;
            this.mod1RadioButton.Location = new System.Drawing.Point(6, 19);
            this.mod1RadioButton.Name = "mod1RadioButton";
            this.mod1RadioButton.Size = new System.Drawing.Size(170, 17);
            this.mod1RadioButton.TabIndex = 5;
            this.mod1RadioButton.TabStop = true;
            this.mod1RadioButton.Text = "Un file unico per tutti gli oggetti";
            this.mod1RadioButton.UseVisualStyleBackColor = true;
            // 
            // mod3RadioButton
            // 
            this.mod3RadioButton.AutoSize = true;
            this.mod3RadioButton.Location = new System.Drawing.Point(6, 65);
            this.mod3RadioButton.Name = "mod3RadioButton";
            this.mod3RadioButton.Size = new System.Drawing.Size(266, 17);
            this.mod3RadioButton.TabIndex = 4;
            this.mod3RadioButton.Text = "Un singolo file per ciascun oggetto diviso in cartelle";
            this.mod3RadioButton.UseVisualStyleBackColor = true;
            // 
            // mod2RadioButton
            // 
            this.mod2RadioButton.AutoSize = true;
            this.mod2RadioButton.Location = new System.Drawing.Point(6, 42);
            this.mod2RadioButton.Name = "mod2RadioButton";
            this.mod2RadioButton.Size = new System.Drawing.Size(169, 17);
            this.mod2RadioButton.TabIndex = 3;
            this.mod2RadioButton.Text = "Un singolo file per ciascun tipo";
            this.mod2RadioButton.UseVisualStyleBackColor = true;
            // 
            // expButton
            // 
            this.expButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.expButton.Location = new System.Drawing.Point(467, 353);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(107, 37);
            this.expButton.TabIndex = 45;
            this.expButton.Text = "Procedi";
            this.expButton.UseVisualStyleBackColor = false;
            this.expButton.Click += new System.EventHandler(this.expButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Sfoglia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // destTextBox
            // 
            this.destTextBox.Location = new System.Drawing.Point(25, 23);
            this.destTextBox.Name = "destTextBox";
            this.destTextBox.Size = new System.Drawing.Size(427, 20);
            this.destTextBox.TabIndex = 53;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.triggerCheckBox);
            this.groupBox4.Controls.Add(this.funzionCheckBox);
            this.groupBox4.Controls.Add(this.viewCheckBox);
            this.groupBox4.Controls.Add(this.procedureCheckBox);
            this.groupBox4.Controls.Add(this.allCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 222);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 49);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Oggetti";
            // 
            // triggerCheckBox
            // 
            this.triggerCheckBox.AutoSize = true;
            this.triggerCheckBox.Checked = true;
            this.triggerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.triggerCheckBox.Enabled = false;
            this.triggerCheckBox.Location = new System.Drawing.Point(288, 23);
            this.triggerCheckBox.Name = "triggerCheckBox";
            this.triggerCheckBox.Size = new System.Drawing.Size(59, 17);
            this.triggerCheckBox.TabIndex = 56;
            this.triggerCheckBox.Text = "Trigger";
            this.triggerCheckBox.UseVisualStyleBackColor = true;
            // 
            // funzionCheckBox
            // 
            this.funzionCheckBox.AutoSize = true;
            this.funzionCheckBox.Checked = true;
            this.funzionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.funzionCheckBox.Enabled = false;
            this.funzionCheckBox.Location = new System.Drawing.Point(217, 23);
            this.funzionCheckBox.Name = "funzionCheckBox";
            this.funzionCheckBox.Size = new System.Drawing.Size(65, 17);
            this.funzionCheckBox.TabIndex = 55;
            this.funzionCheckBox.Text = "Funzioni";
            this.funzionCheckBox.UseVisualStyleBackColor = true;
            // 
            // viewCheckBox
            // 
            this.viewCheckBox.AutoSize = true;
            this.viewCheckBox.Checked = true;
            this.viewCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewCheckBox.Enabled = false;
            this.viewCheckBox.Location = new System.Drawing.Point(81, 23);
            this.viewCheckBox.Name = "viewCheckBox";
            this.viewCheckBox.Size = new System.Drawing.Size(49, 17);
            this.viewCheckBox.TabIndex = 54;
            this.viewCheckBox.Text = "Viste";
            this.viewCheckBox.UseVisualStyleBackColor = true;
            // 
            // procedureCheckBox
            // 
            this.procedureCheckBox.AutoSize = true;
            this.procedureCheckBox.Checked = true;
            this.procedureCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.procedureCheckBox.Enabled = false;
            this.procedureCheckBox.Location = new System.Drawing.Point(136, 23);
            this.procedureCheckBox.Name = "procedureCheckBox";
            this.procedureCheckBox.Size = new System.Drawing.Size(75, 17);
            this.procedureCheckBox.TabIndex = 53;
            this.procedureCheckBox.Text = "Procedure";
            this.procedureCheckBox.UseVisualStyleBackColor = true;
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Checked = true;
            this.allCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allCheckBox.Location = new System.Drawing.Point(20, 23);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(47, 17);
            this.allCheckBox.TabIndex = 52;
            this.allCheckBox.Text = "Tutti";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.checkEdit5_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.destTextBox);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Location = new System.Drawing.Point(12, 277);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(562, 47);
            this.groupBox5.TabIndex = 58;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Percorso destinazione";
            // 
            // progressPanel
            // 
            this.progressPanel.Controls.Add(this.restartButton);
            this.progressPanel.Controls.Add(this.progressLabel);
            this.progressPanel.Controls.Add(this.progressBar1);
            this.progressPanel.Location = new System.Drawing.Point(48, 340);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(411, 66);
            this.progressPanel.TabIndex = 59;
            this.progressPanel.Visible = false;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(323, 8);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(84, 39);
            this.restartButton.TabIndex = 59;
            this.restartButton.Text = "Ricomincia";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(10, 9);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(160, 20);
            this.progressLabel.TabIndex = 58;
            this.progressLabel.Text = "Operazione in corso";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 23);
            this.progressBar1.TabIndex = 57;
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 420);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.expButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "WizardForm";
            this.Text = "Export SQL";
            this.Load += new System.EventHandler(this.WizardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton altroRadioButton;
        private System.Windows.Forms.RadioButton indeRadioButton;
        private System.Windows.Forms.TextBox INDEBuildFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sqlServerRadioButton;
        private System.Windows.Forms.RadioButton oracleRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton mod1RadioButton;
        private System.Windows.Forms.RadioButton mod3RadioButton;
        private System.Windows.Forms.RadioButton mod2RadioButton;
        private System.Windows.Forms.Button expButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox destTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox triggerCheckBox;
        private System.Windows.Forms.CheckBox funzionCheckBox;
        private System.Windows.Forms.CheckBox viewCheckBox;
        private System.Windows.Forms.CheckBox procedureCheckBox;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox OtherText;
    }
}

