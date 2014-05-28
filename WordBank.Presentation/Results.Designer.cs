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
            this._panelResults = new System.Windows.Forms.Panel();
            this._panelStats = new System.Windows.Forms.Panel();
            this._lblResults = new System.Windows.Forms.Label();
            this._lblAnswers = new System.Windows.Forms.Label();
            this._lblWords = new System.Windows.Forms.Label();
            this._btnRestart = new System.Windows.Forms.Button();
            this._btnExit = new System.Windows.Forms.Button();
            this._lblScore = new System.Windows.Forms.Label();
            this._panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panelResults
            // 
            this._panelResults.AutoScroll = true;
            this._panelResults.Location = new System.Drawing.Point(13, 40);
            this._panelResults.Name = "_panelResults";
            this._panelResults.Size = new System.Drawing.Size(360, 436);
            this._panelResults.TabIndex = 0;
            // 
            // _panelStats
            // 
            this._panelStats.BackColor = System.Drawing.Color.Brown;
            this._panelStats.Controls.Add(this._lblResults);
            this._panelStats.Controls.Add(this._lblAnswers);
            this._panelStats.Controls.Add(this._lblWords);
            this._panelStats.Location = new System.Drawing.Point(13, 6);
            this._panelStats.Name = "_panelStats";
            this._panelStats.Size = new System.Drawing.Size(360, 28);
            this._panelStats.TabIndex = 1;
            // 
            // _lblResults
            // 
            this._lblResults.AutoSize = true;
            this._lblResults.ForeColor = System.Drawing.Color.White;
            this._lblResults.Location = new System.Drawing.Point(312, 7);
            this._lblResults.Name = "_lblResults";
            this._lblResults.Size = new System.Drawing.Size(42, 13);
            this._lblResults.TabIndex = 2;
            this._lblResults.Text = "Results";
            // 
            // _lblAnswers
            // 
            this._lblAnswers.AutoSize = true;
            this._lblAnswers.ForeColor = System.Drawing.Color.White;
            this._lblAnswers.Location = new System.Drawing.Point(169, 7);
            this._lblAnswers.Name = "_lblAnswers";
            this._lblAnswers.Size = new System.Drawing.Size(47, 13);
            this._lblAnswers.TabIndex = 1;
            this._lblAnswers.Text = "Answers";
            // 
            // _lblWords
            // 
            this._lblWords.AutoSize = true;
            this._lblWords.ForeColor = System.Drawing.Color.White;
            this._lblWords.Location = new System.Drawing.Point(4, 7);
            this._lblWords.Name = "_lblWords";
            this._lblWords.Size = new System.Drawing.Size(38, 13);
            this._lblWords.TabIndex = 0;
            this._lblWords.Text = "Words";
            // 
            // _btnRestart
            // 
            this._btnRestart.Location = new System.Drawing.Point(217, 482);
            this._btnRestart.Name = "_btnRestart";
            this._btnRestart.Size = new System.Drawing.Size(75, 23);
            this._btnRestart.TabIndex = 2;
            this._btnRestart.Text = "Try Again";
            this._btnRestart.UseVisualStyleBackColor = true;
            this._btnRestart.Click += new System.EventHandler(this.RestartApplication_Click);
            // 
            // _btnExit
            // 
            this._btnExit.Location = new System.Drawing.Point(298, 482);
            this._btnExit.Name = "_btnExit";
            this._btnExit.Size = new System.Drawing.Size(75, 23);
            this._btnExit.TabIndex = 3;
            this._btnExit.Text = "Exit";
            this._btnExit.UseVisualStyleBackColor = true;
            this._btnExit.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.ForeColor = System.Drawing.Color.DimGray;
            this._lblScore.Location = new System.Drawing.Point(12, 486);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(19, 13);
            this._lblScore.TabIndex = 4;
            this._lblScore.Text = "----";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 509);
            this.Controls.Add(this._lblScore);
            this.Controls.Add(this._btnExit);
            this.Controls.Add(this._btnRestart);
            this.Controls.Add(this._panelStats);
            this.Controls.Add(this._panelResults);
            this.MaximumSize = new System.Drawing.Size(399, 547);
            this.MinimumSize = new System.Drawing.Size(399, 547);
            this.Name = "Results";
            this.Text = "Test Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this._panelStats.ResumeLayout(false);
            this._panelStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panelResults;
        private System.Windows.Forms.Panel _panelStats;
        private System.Windows.Forms.Label _lblResults;
        private System.Windows.Forms.Label _lblAnswers;
        private System.Windows.Forms.Label _lblWords;
        private System.Windows.Forms.Button _btnRestart;
        private System.Windows.Forms.Button _btnExit;
        private System.Windows.Forms.Label _lblScore;
    }
}