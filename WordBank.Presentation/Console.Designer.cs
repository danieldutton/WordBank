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
            this._txtBoxAnswer = new System.Windows.Forms.TextBox();
            this._btnSubmit = new System.Windows.Forms.Button();
            this._btnReplay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._lblQuestionCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtBoxAnswer
            // 
            this._txtBoxAnswer.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtBoxAnswer.Location = new System.Drawing.Point(56, 76);
            this._txtBoxAnswer.Name = "_txtBoxAnswer";
            this._txtBoxAnswer.Size = new System.Drawing.Size(129, 20);
            this._txtBoxAnswer.TabIndex = 3;
            // 
            // _btnSubmit
            // 
            this._btnSubmit.Location = new System.Drawing.Point(191, 76);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new System.Drawing.Size(48, 23);
            this._btnSubmit.TabIndex = 4;
            this._btnSubmit.Text = "Submit";
            this._btnSubmit.UseVisualStyleBackColor = true;
            this._btnSubmit.Click += new System.EventHandler(this.SubmitAnswer_Click);
            // 
            // _btnReplay
            // 
            this._btnReplay.Image = ((System.Drawing.Image)(resources.GetObject("_btnReplay.Image")));
            this._btnReplay.Location = new System.Drawing.Point(12, 76);
            this._btnReplay.Name = "_btnReplay";
            this._btnReplay.Size = new System.Drawing.Size(38, 23);
            this._btnReplay.TabIndex = 5;
            this._btnReplay.UseVisualStyleBackColor = true;
            this._btnReplay.Click += new System.EventHandler(this.ReplayWord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 57);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // _lblQuestionCount
            // 
            this._lblQuestionCount.AutoSize = true;
            this._lblQuestionCount.BackColor = System.Drawing.Color.Transparent;
            this._lblQuestionCount.ForeColor = System.Drawing.Color.DimGray;
            this._lblQuestionCount.Location = new System.Drawing.Point(12, 120);
            this._lblQuestionCount.Name = "_lblQuestionCount";
            this._lblQuestionCount.Size = new System.Drawing.Size(13, 13);
            this._lblQuestionCount.TabIndex = 7;
            this._lblQuestionCount.Text = "1";
            // 
            // Console
            // 
            this.AcceptButton = this._btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(245, 147);
            this.Controls.Add(this._lblQuestionCount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._btnReplay);
            this.Controls.Add(this._btnSubmit);
            this.Controls.Add(this._txtBoxAnswer);
            this.MaximumSize = new System.Drawing.Size(261, 185);
            this.MinimumSize = new System.Drawing.Size(261, 185);
            this.Name = "Console";
            this.Text = "WordBank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtBoxAnswer;
        private System.Windows.Forms.Button _btnSubmit;
        private System.Windows.Forms.Button _btnReplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _lblQuestionCount;
    }
}