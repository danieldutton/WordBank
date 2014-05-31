namespace WordBank.Presentation
{
    partial class TestConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestConsole));
            this._picBoxHeader = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnReplay = new System.Windows.Forms.Button();
            this._txtBoxAnswer = new System.Windows.Forms.TextBox();
            this._btnSubmit = new System.Windows.Forms.Button();
            this._lblQuestionCount = new System.Windows.Forms.Label();
            this._btnFinishTestEarly = new System.Windows.Forms.Button();
            this._panelWordCount = new System.Windows.Forms.Panel();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPageTest = new System.Windows.Forms.TabPage();
            this._tabPageImport = new System.Windows.Forms.TabPage();
            this._lblImportInstructions = new System.Windows.Forms.Label();
            this._btnUseDefaults = new System.Windows.Forms.Button();
            this._btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._picBoxHeader)).BeginInit();
            this.panel1.SuspendLayout();
            this._panelWordCount.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._tabPageTest.SuspendLayout();
            this._tabPageImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // _picBoxHeader
            // 
            this._picBoxHeader.BackColor = System.Drawing.Color.Transparent;
            this._picBoxHeader.Image = ((System.Drawing.Image)(resources.GetObject("_picBoxHeader.Image")));
            this._picBoxHeader.Location = new System.Drawing.Point(6, 6);
            this._picBoxHeader.Name = "_picBoxHeader";
            this._picBoxHeader.Size = new System.Drawing.Size(246, 57);
            this._picBoxHeader.TabIndex = 6;
            this._picBoxHeader.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this._btnReplay);
            this.panel1.Controls.Add(this._txtBoxAnswer);
            this.panel1.Controls.Add(this._btnSubmit);
            this.panel1.Location = new System.Drawing.Point(6, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 36);
            this.panel1.TabIndex = 9;
            // 
            // _btnReplay
            // 
            this._btnReplay.Image = ((System.Drawing.Image)(resources.GetObject("_btnReplay.Image")));
            this._btnReplay.Location = new System.Drawing.Point(13, 6);
            this._btnReplay.Name = "_btnReplay";
            this._btnReplay.Size = new System.Drawing.Size(38, 23);
            this._btnReplay.TabIndex = 6;
            this._btnReplay.UseVisualStyleBackColor = true;
            this._btnReplay.Click += new System.EventHandler(this.ReplayWordAudio_Click);
            // 
            // _txtBoxAnswer
            // 
            this._txtBoxAnswer.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtBoxAnswer.Location = new System.Drawing.Point(60, 8);
            this._txtBoxAnswer.Name = "_txtBoxAnswer";
            this._txtBoxAnswer.Size = new System.Drawing.Size(129, 20);
            this._txtBoxAnswer.TabIndex = 3;
            // 
            // _btnSubmit
            // 
            this._btnSubmit.Location = new System.Drawing.Point(191, 6);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new System.Drawing.Size(51, 23);
            this._btnSubmit.TabIndex = 4;
            this._btnSubmit.Text = "Submit";
            this._btnSubmit.UseVisualStyleBackColor = true;
            this._btnSubmit.Click += new System.EventHandler(this.SubmitAnswer_Click);
            // 
            // _lblQuestionCount
            // 
            this._lblQuestionCount.AutoSize = true;
            this._lblQuestionCount.BackColor = System.Drawing.Color.Transparent;
            this._lblQuestionCount.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblQuestionCount.ForeColor = System.Drawing.Color.White;
            this._lblQuestionCount.Location = new System.Drawing.Point(1, 3);
            this._lblQuestionCount.Name = "_lblQuestionCount";
            this._lblQuestionCount.Size = new System.Drawing.Size(14, 16);
            this._lblQuestionCount.TabIndex = 7;
            this._lblQuestionCount.Text = "1";
            // 
            // _btnFinishTestEarly
            // 
            this._btnFinishTestEarly.Location = new System.Drawing.Point(197, 111);
            this._btnFinishTestEarly.Name = "_btnFinishTestEarly";
            this._btnFinishTestEarly.Size = new System.Drawing.Size(51, 23);
            this._btnFinishTestEarly.TabIndex = 8;
            this._btnFinishTestEarly.Text = "Finish";
            this._btnFinishTestEarly.UseVisualStyleBackColor = true;
            this._btnFinishTestEarly.Click += new System.EventHandler(this.EndTestEarly_Click);
            // 
            // _panelWordCount
            // 
            this._panelWordCount.BackColor = System.Drawing.Color.Brown;
            this._panelWordCount.Controls.Add(this._lblQuestionCount);
            this._panelWordCount.Location = new System.Drawing.Point(6, 112);
            this._panelWordCount.Name = "_panelWordCount";
            this._panelWordCount.Size = new System.Drawing.Size(189, 22);
            this._panelWordCount.TabIndex = 10;
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPageTest);
            this._tabControl.Controls.Add(this._tabPageImport);
            this._tabControl.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tabControl.Location = new System.Drawing.Point(7, 8);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(265, 170);
            this._tabControl.TabIndex = 11;
            // 
            // _tabPageTest
            // 
            this._tabPageTest.Controls.Add(this._picBoxHeader);
            this._tabPageTest.Controls.Add(this._panelWordCount);
            this._tabPageTest.Controls.Add(this._btnFinishTestEarly);
            this._tabPageTest.Controls.Add(this.panel1);
            this._tabPageTest.Location = new System.Drawing.Point(4, 25);
            this._tabPageTest.Name = "_tabPageTest";
            this._tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageTest.Size = new System.Drawing.Size(257, 141);
            this._tabPageTest.TabIndex = 0;
            this._tabPageTest.Text = "Test";
            this._tabPageTest.UseVisualStyleBackColor = true;
            // 
            // _tabPageImport
            // 
            this._tabPageImport.Controls.Add(this._lblImportInstructions);
            this._tabPageImport.Controls.Add(this._btnUseDefaults);
            this._tabPageImport.Controls.Add(this._btnImport);
            this._tabPageImport.Location = new System.Drawing.Point(4, 25);
            this._tabPageImport.Name = "_tabPageImport";
            this._tabPageImport.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageImport.Size = new System.Drawing.Size(257, 141);
            this._tabPageImport.TabIndex = 1;
            this._tabPageImport.Text = "Import";
            this._tabPageImport.UseVisualStyleBackColor = true;
            // 
            // _lblImportInstructions
            // 
            this._lblImportInstructions.AutoSize = true;
            this._lblImportInstructions.ForeColor = System.Drawing.Color.Maroon;
            this._lblImportInstructions.Location = new System.Drawing.Point(6, 7);
            this._lblImportInstructions.MaximumSize = new System.Drawing.Size(250, 50);
            this._lblImportInstructions.Name = "_lblImportInstructions";
            this._lblImportInstructions.Size = new System.Drawing.Size(244, 48);
            this._lblImportInstructions.TabIndex = 2;
            this._lblImportInstructions.Text = "To import a new word file, click inport, browse to the xml file and click ok.  Th" +
    "e new test will begin immediately.";
            // 
            // _btnUseDefaults
            // 
            this._btnUseDefaults.Location = new System.Drawing.Point(6, 115);
            this._btnUseDefaults.Name = "_btnUseDefaults";
            this._btnUseDefaults.Size = new System.Drawing.Size(90, 23);
            this._btnUseDefaults.TabIndex = 1;
            this._btnUseDefaults.Text = "Use defaults";
            this._btnUseDefaults.UseVisualStyleBackColor = true;
            this._btnUseDefaults.Click += new System.EventHandler(this.ResetToDefaultWordXmlFile);
            // 
            // _btnImport
            // 
            this._btnImport.Location = new System.Drawing.Point(176, 115);
            this._btnImport.Name = "_btnImport";
            this._btnImport.Size = new System.Drawing.Size(75, 23);
            this._btnImport.TabIndex = 0;
            this._btnImport.Text = "Import";
            this._btnImport.UseVisualStyleBackColor = true;
            this._btnImport.Click += new System.EventHandler(this.ImportWordFile_Click);
            // 
            // TestConsole
            // 
            this.AcceptButton = this._btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(277, 189);
            this.Controls.Add(this._tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(293, 227);
            this.MinimumSize = new System.Drawing.Size(293, 227);
            this.Name = "TestConsole";
            this.Text = "WordBank";
            ((System.ComponentModel.ISupportInitialize)(this._picBoxHeader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._panelWordCount.ResumeLayout(false);
            this._panelWordCount.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this._tabPageTest.ResumeLayout(false);
            this._tabPageImport.ResumeLayout(false);
            this._tabPageImport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _picBoxHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnReplay;
        private System.Windows.Forms.TextBox _txtBoxAnswer;
        private System.Windows.Forms.Button _btnSubmit;
        private System.Windows.Forms.Label _lblQuestionCount;
        private System.Windows.Forms.Button _btnFinishTestEarly;
        private System.Windows.Forms.Panel _panelWordCount;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPageTest;
        private System.Windows.Forms.TabPage _tabPageImport;
        private System.Windows.Forms.Button _btnImport;
        private System.Windows.Forms.Button _btnUseDefaults;
        private System.Windows.Forms.Label _lblImportInstructions;
    }
}