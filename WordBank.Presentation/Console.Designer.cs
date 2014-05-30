namespace WordBank.Presentation
{
    partial class Console
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Console));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnReplay = new System.Windows.Forms.Button();
            this._txtBoxUserAnswer = new System.Windows.Forms.TextBox();
            this._btnSubmit = new System.Windows.Forms.Button();
            this._lblQuestionCount = new System.Windows.Forms.Label();
            this._btnEndTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._btnResetDefaults = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 57);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this._btnReplay);
            this.panel1.Controls.Add(this._txtBoxUserAnswer);
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
            // _txtBoxUserAnswer
            // 
            this._txtBoxUserAnswer.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtBoxUserAnswer.Location = new System.Drawing.Point(60, 8);
            this._txtBoxUserAnswer.Name = "_txtBoxUserAnswer";
            this._txtBoxUserAnswer.Size = new System.Drawing.Size(129, 20);
            this._txtBoxUserAnswer.TabIndex = 3;
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
            // _btnEndTest
            // 
            this._btnEndTest.Location = new System.Drawing.Point(197, 111);
            this._btnEndTest.Name = "_btnEndTest";
            this._btnEndTest.Size = new System.Drawing.Size(51, 23);
            this._btnEndTest.TabIndex = 8;
            this._btnEndTest.Text = "Finish";
            this._btnEndTest.UseVisualStyleBackColor = true;
            this._btnEndTest.Click += new System.EventHandler(this.EndTestEarly_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this._lblQuestionCount);
            this.panel2.Location = new System.Drawing.Point(6, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 22);
            this.panel2.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 170);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this._btnEndTest);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this._btnResetDefaults);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Import";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _btnResetDefaults
            // 
            this._btnResetDefaults.Location = new System.Drawing.Point(6, 115);
            this._btnResetDefaults.Name = "_btnResetDefaults";
            this._btnResetDefaults.Size = new System.Drawing.Size(103, 23);
            this._btnResetDefaults.TabIndex = 1;
            this._btnResetDefaults.Text = "Reset to defaults";
            this._btnResetDefaults.UseVisualStyleBackColor = true;
            this._btnResetDefaults.Click += new System.EventHandler(this.ResetToDefaultWordXmlFile);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ImportWordFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.MaximumSize = new System.Drawing.Size(250, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "To import a new word file, click inport, browse to the xml file and click ok.  Th" +
    "en return to the test tab and start taking the test as usual.";
            // 
            // Console
            // 
            this.AcceptButton = this._btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(277, 189);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(293, 227);
            this.MinimumSize = new System.Drawing.Size(293, 227);
            this.Name = "Console";
            this.Text = "WordBank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnReplay;
        private System.Windows.Forms.TextBox _txtBoxUserAnswer;
        private System.Windows.Forms.Button _btnSubmit;
        private System.Windows.Forms.Label _lblQuestionCount;
        private System.Windows.Forms.Button _btnEndTest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button _btnResetDefaults;
        private System.Windows.Forms.Label label1;
    }
}