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
            this._txtBoxAnswer = new System.Windows.Forms.TextBox();
            this._btnSubmit = new System.Windows.Forms.Button();
            this._lblQuestionCount = new System.Windows.Forms.Label();
            this._btnEndTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 57);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this._btnReplay);
            this.panel1.Controls.Add(this._txtBoxAnswer);
            this.panel1.Controls.Add(this._btnSubmit);
            this.panel1.Location = new System.Drawing.Point(12, 75);
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
            this._btnReplay.Click += new System.EventHandler(this.ReplayWord_Click);
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
            this._btnSubmit.Location = new System.Drawing.Point(195, 6);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new System.Drawing.Size(48, 23);
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
            this._lblQuestionCount.ForeColor = System.Drawing.Color.SlateGray;
            this._lblQuestionCount.Location = new System.Drawing.Point(9, 124);
            this._lblQuestionCount.Name = "_lblQuestionCount";
            this._lblQuestionCount.Size = new System.Drawing.Size(14, 16);
            this._lblQuestionCount.TabIndex = 7;
            this._lblQuestionCount.Text = "1";
            // 
            // _btnEndTest
            // 
            this._btnEndTest.Location = new System.Drawing.Point(207, 117);
            this._btnEndTest.Name = "_btnEndTest";
            this._btnEndTest.Size = new System.Drawing.Size(48, 23);
            this._btnEndTest.TabIndex = 8;
            this._btnEndTest.Text = "Finish";
            this._btnEndTest.UseVisualStyleBackColor = true;
            this._btnEndTest.Click += new System.EventHandler(this.EndTestEarly_Click);
            // 
            // Console
            // 
            this.AcceptButton = this._btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(269, 147);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnEndTest);
            this.Controls.Add(this._lblQuestionCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(285, 185);
            this.MinimumSize = new System.Drawing.Size(285, 185);
            this.Name = "Console";
            this.Text = "WordBank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnReplay;
        private System.Windows.Forms.TextBox _txtBoxAnswer;
        private System.Windows.Forms.Button _btnSubmit;
        private System.Windows.Forms.Label _lblQuestionCount;
        private System.Windows.Forms.Button _btnEndTest;
    }
}