
namespace InzWiedzZad3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.e = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tbExport = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbStyntax = new System.Windows.Forms.TextBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbSamples = new System.Windows.Forms.TextBox();
            this.tbError = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBoxError = new System.Windows.Forms.CheckBox();
            this.chkBoxIteration = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLearning = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbIteration = new System.Windows.Forms.TextBox();
            this.btnInputsFile = new System.Windows.Forms.Button();
            this.tbInputs = new System.Windows.Forms.TextBox();
            this.btnInputs = new System.Windows.Forms.Button();
            this.btnCorrection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.tbStatus = new System.Windows.Forms.RichTextBox();
            this.cbEpoch = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(401, 100);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(75, 23);
            this.e.TabIndex = 6;
            this.e.Text = "Wygeneruj";
            this.e.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1);
            this.tabControl.Controls.Add(this.tab2);
            this.tabControl.Location = new System.Drawing.Point(856, 18);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(219, 517);
            this.tabControl.TabIndex = 47;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tbExport);
            this.tab1.Controls.Add(this.btnLoad);
            this.tab1.Controls.Add(this.btnSave);
            this.tab1.Controls.Add(this.btnPath);
            this.tab1.Controls.Add(this.btnCreate);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.tbPath);
            this.tab1.Controls.Add(this.tbMax);
            this.tab1.Controls.Add(this.tbMin);
            this.tab1.Controls.Add(this.tbStyntax);
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(211, 489);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Generowanie";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tbExport
            // 
            this.tbExport.Location = new System.Drawing.Point(10, 244);
            this.tbExport.Name = "tbExport";
            this.tbExport.Size = new System.Drawing.Size(190, 23);
            this.tbExport.TabIndex = 60;
            this.tbExport.TextChanged += new System.EventHandler(this.tbExport_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(10, 302);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(190, 23);
            this.btnLoad.TabIndex = 59;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 23);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(10, 176);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(190, 23);
            this.btnPath.TabIndex = 56;
            this.btnPath.Text = "Wyznacz";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(194, 23);
            this.btnCreate.TabIndex = 55;
            this.btnCreate.Text = "Wygeneruj";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Wyznacz ścieżkę [x-y-..-z]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Zakres losowanych liczb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Schemat";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(10, 147);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(190, 23);
            this.tbPath.TabIndex = 50;
            this.tbPath.Text = "1-1-1";
            this.tbPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(106, 71);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(94, 23);
            this.tbMax.TabIndex = 49;
            this.tbMax.Text = "1,00";
            this.tbMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(6, 71);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(94, 23);
            this.tbMin.TabIndex = 48;
            this.tbMin.Text = "0,00";
            this.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // tbStyntax
            // 
            this.tbStyntax.Location = new System.Drawing.Point(6, 27);
            this.tbStyntax.Name = "tbStyntax";
            this.tbStyntax.Size = new System.Drawing.Size(194, 23);
            this.tbStyntax.TabIndex = 47;
            this.tbStyntax.Text = "2-2-1";
            this.tbStyntax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStyntax.TextChanged += new System.EventHandler(this.tbStyntax_TextChanged);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.cbEpoch);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.btnQuestion);
            this.tab2.Controls.Add(this.tbQuestion);
            this.tab2.Controls.Add(this.tbSamples);
            this.tab2.Controls.Add(this.tbError);
            this.tab2.Controls.Add(this.label5);
            this.tab2.Controls.Add(this.chkBoxError);
            this.tab2.Controls.Add(this.chkBoxIteration);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.tbLearning);
            this.tab2.Controls.Add(this.tbB);
            this.tab2.Controls.Add(this.tbIteration);
            this.tab2.Controls.Add(this.btnInputsFile);
            this.tab2.Controls.Add(this.tbInputs);
            this.tab2.Controls.Add(this.btnInputs);
            this.tab2.Controls.Add(this.btnCorrection);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(211, 489);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Sieć neuronowa";
            this.tab2.UseVisualStyleBackColor = true;
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 82;
            this.label9.Text = "Parametry uczenia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 81;
            this.label8.Text = "Podane próbki";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(22, 38);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(172, 23);
            this.btnQuestion.TabIndex = 79;
            this.btnQuestion.Text = "Zapytaj";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(22, 9);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(172, 23);
            this.tbQuestion.TabIndex = 78;
            this.tbQuestion.Text = "0 0";
            this.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // tbSamples
            // 
            this.tbSamples.Location = new System.Drawing.Point(20, 169);
            this.tbSamples.Multiline = true;
            this.tbSamples.Name = "tbSamples";
            this.tbSamples.Size = new System.Drawing.Size(174, 103);
            this.tbSamples.TabIndex = 80;
            this.tbSamples.TextChanged += new System.EventHandler(this.tbSamples_TextChanged);
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(61, 416);
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(100, 23);
            this.tbError.TabIndex = 77;
            this.tbError.Text = "0,1";
            this.tbError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 76;
            this.label5.Text = "Błąd mniejszy niż założony";
            // 
            // chkBoxError
            // 
            this.chkBoxError.AutoSize = true;
            this.chkBoxError.Location = new System.Drawing.Point(20, 397);
            this.chkBoxError.Name = "chkBoxError";
            this.chkBoxError.Size = new System.Drawing.Size(15, 14);
            this.chkBoxError.TabIndex = 75;
            this.chkBoxError.UseVisualStyleBackColor = true;
            this.chkBoxError.CheckedChanged += new System.EventHandler(this.chkBoxError_CheckedChanged);
            // 
            // chkBoxIteration
            // 
            this.chkBoxIteration.AutoSize = true;
            this.chkBoxIteration.Checked = true;
            this.chkBoxIteration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxIteration.Location = new System.Drawing.Point(20, 340);
            this.chkBoxIteration.Name = "chkBoxIteration";
            this.chkBoxIteration.Size = new System.Drawing.Size(64, 19);
            this.chkBoxIteration.TabIndex = 74;
            this.chkBoxIteration.Text = "Iteracje";
            this.chkBoxIteration.UseVisualStyleBackColor = true;
            this.chkBoxIteration.CheckedChanged += new System.EventHandler(this.chkBoxIteration_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "mi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "B: ";
            // 
            // tbLearning
            // 
            this.tbLearning.Location = new System.Drawing.Point(105, 309);
            this.tbLearning.Name = "tbLearning";
            this.tbLearning.Size = new System.Drawing.Size(26, 23);
            this.tbLearning.TabIndex = 71;
            this.tbLearning.Text = "0,1";
            this.tbLearning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLearning.TextChanged += new System.EventHandler(this.tbLearning_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(41, 309);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(26, 23);
            this.tbB.TabIndex = 70;
            this.tbB.Text = "1";
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIteration
            // 
            this.tbIteration.Location = new System.Drawing.Point(61, 359);
            this.tbIteration.Name = "tbIteration";
            this.tbIteration.Size = new System.Drawing.Size(95, 23);
            this.tbIteration.TabIndex = 68;
            this.tbIteration.Text = "100";
            this.tbIteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbIteration.TextChanged += new System.EventHandler(this.tbIteration_TextChanged);
            // 
            // btnInputsFile
            // 
            this.btnInputsFile.Location = new System.Drawing.Point(20, 125);
            this.btnInputsFile.Name = "btnInputsFile";
            this.btnInputsFile.Size = new System.Drawing.Size(174, 23);
            this.btnInputsFile.TabIndex = 67;
            this.btnInputsFile.Text = "Wczytaj próbki z pliku";
            this.btnInputsFile.UseVisualStyleBackColor = true;
            this.btnInputsFile.Click += new System.EventHandler(this.btnInputsFile_Click);
            // 
            // tbInputs
            // 
            this.tbInputs.Location = new System.Drawing.Point(20, 67);
            this.tbInputs.Name = "tbInputs";
            this.tbInputs.Size = new System.Drawing.Size(174, 23);
            this.tbInputs.TabIndex = 65;
            this.tbInputs.Text = "1 0|1";
            this.tbInputs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInputs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInputs
            // 
            this.btnInputs.Location = new System.Drawing.Point(20, 96);
            this.btnInputs.Name = "btnInputs";
            this.btnInputs.Size = new System.Drawing.Size(174, 23);
            this.btnInputs.TabIndex = 64;
            this.btnInputs.Text = "Wstaw próbkę";
            this.btnInputs.UseVisualStyleBackColor = true;
            this.btnInputs.Click += new System.EventHandler(this.btnInputs_Click);
            // 
            // btnCorrection
            // 
            this.btnCorrection.Location = new System.Drawing.Point(20, 445);
            this.btnCorrection.Name = "btnCorrection";
            this.btnCorrection.Size = new System.Drawing.Size(174, 23);
            this.btnCorrection.TabIndex = 0;
            this.btnCorrection.Text = "Korekcja";
            this.btnCorrection.UseVisualStyleBackColor = true;
            this.btnCorrection.Click += new System.EventHandler(this.btnCorrection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Tablica";
            // 
            // rtbMain
            // 
            this.rtbMain.Location = new System.Drawing.Point(12, 42);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.Size = new System.Drawing.Size(844, 409);
            this.rtbMain.TabIndex = 58;
            this.rtbMain.Text = "";
            this.rtbMain.WordWrap = false;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(491, 460);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(363, 75);
            this.tbStatus.TabIndex = 62;
            this.tbStatus.Text = "";
            this.tbStatus.WordWrap = false;
            // 
            // cbEpoch
            // 
            this.cbEpoch.AutoSize = true;
            this.cbEpoch.Location = new System.Drawing.Point(150, 313);
            this.cbEpoch.Name = "cbEpoch";
            this.cbEpoch.Size = new System.Drawing.Size(55, 19);
            this.cbEpoch.TabIndex = 83;
            this.cbEpoch.Text = "Epoki";
            this.cbEpoch.UseVisualStyleBackColor = true;
            this.cbEpoch.CheckedChanged += new System.EventHandler(this.cbEpoch_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 547);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wygeneruj";
            this.tabControl.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button e;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TextBox tbExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbStyntax;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.RichTextBox tbStatus;
        private System.Windows.Forms.Button btnCorrection;
        private System.Windows.Forms.TextBox tbInputs;
        private System.Windows.Forms.Button btnInputs;
        private System.Windows.Forms.Button btnInputsFile;
        private System.Windows.Forms.TextBox tbIteration;
        private System.Windows.Forms.TextBox tbLearning;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBoxError;
        private System.Windows.Forms.CheckBox chkBoxIteration;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSamples;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbEpoch;
    }
}

