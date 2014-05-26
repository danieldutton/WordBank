namespace WordBank.Presentation
{
    partial class Main
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
            this._lblWordPrompt = new System.Windows.Forms.Label();
            this._btnNext = new System.Windows.Forms.Button();
            this._txtBoxAnswer = new System.Windows.Forms.TextBox();
            this._btnSubmit = new System.Windows.Forms.Button();
            this._btnReplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblWordPrompt
            // 
            this._lblWordPrompt.AutoSize = true;
            this._lblWordPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblWordPrompt.Location = new System.Drawing.Point(12, 9);
            this._lblWordPrompt.Name = "_lblWordPrompt";
            this._lblWordPrompt.Size = new System.Drawing.Size(145, 31);
            this._lblWordPrompt.TabIndex = 1;
            this._lblWordPrompt.Text = "Question 0";
            // 
            // _btnNext
            // 
            this._btnNext.Location = new System.Drawing.Point(43, 43);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(20, 23);
            this._btnNext.TabIndex = 2;
            this._btnNext.Text = "Next";
            this._btnNext.UseVisualStyleBackColor = true;
            this._btnNext.Click += new System.EventHandler(this.NextWord_Click);
            // 
            // _txtBoxAnswer
            // 
            this._txtBoxAnswer.Location = new System.Drawing.Point(69, 45);
            this._txtBoxAnswer.Name = "_txtBoxAnswer";
            this._txtBoxAnswer.Size = new System.Drawing.Size(78, 20);
            this._txtBoxAnswer.TabIndex = 3;
            // 
            // _btnSubmit
            // 
            this._btnSubmit.Location = new System.Drawing.Point(69, 72);
            this._btnSubmit.Name = "_btnSubmit";
            this._btnSubmit.Size = new System.Drawing.Size(55, 23);
            this._btnSubmit.TabIndex = 4;
            this._btnSubmit.Text = "Submit";
            this._btnSubmit.UseVisualStyleBackColor = true;
            this._btnSubmit.Click += new System.EventHandler(this.SubmitAnswer_Click);
            // 
            // _btnReplay
            // 
            this._btnReplay.Location = new System.Drawing.Point(18, 43);
            this._btnReplay.Name = "_btnReplay";
            this._btnReplay.Size = new System.Drawing.Size(19, 23);
            this._btnReplay.TabIndex = 5;
            this._btnReplay.Text = "Replay";
            this._btnReplay.UseVisualStyleBackColor = true;
            this._btnReplay.Click += new System.EventHandler(this._btnReplay_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 107);
            this.Controls.Add(this._btnReplay);
            this.Controls.Add(this._btnSubmit);
            this.Controls.Add(this._txtBoxAnswer);
            this.Controls.Add(this._btnNext);
            this.Controls.Add(this._lblWordPrompt);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblWordPrompt;
        private System.Windows.Forms.Button _btnNext;
        private System.Windows.Forms.TextBox _txtBoxAnswer;
        private System.Windows.Forms.Button _btnSubmit;
        private System.Windows.Forms.Button _btnReplay;
    }
}