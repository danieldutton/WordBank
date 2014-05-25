namespace WordBank.Presentation
{
    partial class Results
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
            this._txtBoxAnswer = new System.Windows.Forms.TextBox();
            this._btnSubmitAnswer = new System.Windows.Forms.Button();
            this._lblQuestionPrompt = new System.Windows.Forms.Label();
            this._btnReplaySpelling = new System.Windows.Forms.Button();
            this._btnNextSpelling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtBoxAnswer
            // 
            this._txtBoxAnswer.Location = new System.Drawing.Point(56, 133);
            this._txtBoxAnswer.Name = "_txtBoxAnswer";
            this._txtBoxAnswer.Size = new System.Drawing.Size(162, 20);
            this._txtBoxAnswer.TabIndex = 0;
            // 
            // _btnSubmitAnswer
            // 
            this._btnSubmitAnswer.Location = new System.Drawing.Point(56, 158);
            this._btnSubmitAnswer.Name = "_btnSubmitAnswer";
            this._btnSubmitAnswer.Size = new System.Drawing.Size(75, 23);
            this._btnSubmitAnswer.TabIndex = 1;
            this._btnSubmitAnswer.Text = "Submit";
            this._btnSubmitAnswer.UseVisualStyleBackColor = true;
            this._btnSubmitAnswer.Click += new System.EventHandler(this.SubmitAnswer_Click);
            // 
            // _lblQuestionPrompt
            // 
            this._lblQuestionPrompt.AutoSize = true;
            this._lblQuestionPrompt.Location = new System.Drawing.Point(123, 50);
            this._lblQuestionPrompt.Name = "_lblQuestionPrompt";
            this._lblQuestionPrompt.Size = new System.Drawing.Size(19, 13);
            this._lblQuestionPrompt.TabIndex = 2;
            this._lblQuestionPrompt.Text = "----";
            // 
            // _btnReplaySpelling
            // 
            this._btnReplaySpelling.Location = new System.Drawing.Point(36, 78);
            this._btnReplaySpelling.Name = "_btnReplaySpelling";
            this._btnReplaySpelling.Size = new System.Drawing.Size(75, 23);
            this._btnReplaySpelling.TabIndex = 3;
            this._btnReplaySpelling.Text = "Replay";
            this._btnReplaySpelling.UseVisualStyleBackColor = true;
            this._btnReplaySpelling.Click += new System.EventHandler(this.ReplaySpelling_Click);
            // 
            // _btnNextSpelling
            // 
            this._btnNextSpelling.Location = new System.Drawing.Point(142, 78);
            this._btnNextSpelling.Name = "_btnNextSpelling";
            this._btnNextSpelling.Size = new System.Drawing.Size(75, 23);
            this._btnNextSpelling.TabIndex = 4;
            this._btnNextSpelling.Text = "Next";
            this._btnNextSpelling.UseVisualStyleBackColor = true;
            this._btnNextSpelling.Click += new System.EventHandler(this.NextSpelling_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 243);
            this.Controls.Add(this._btnNextSpelling);
            this.Controls.Add(this._btnReplaySpelling);
            this.Controls.Add(this._lblQuestionPrompt);
            this.Controls.Add(this._btnSubmitAnswer);
            this.Controls.Add(this._txtBoxAnswer);
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtBoxAnswer;
        private System.Windows.Forms.Button _btnSubmitAnswer;
        private System.Windows.Forms.Label _lblQuestionPrompt;
        private System.Windows.Forms.Button _btnReplaySpelling;
        private System.Windows.Forms.Button _btnNextSpelling;
    }
}