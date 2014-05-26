namespace WordBank.Presentation
{
    partial class Settings
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
            this._lblAnswerPrompt = new System.Windows.Forms.Label();
            this._comboBoxQuestionCount = new System.Windows.Forms.ComboBox();
            this._lblQuestions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblAnswerPrompt
            // 
            this._lblAnswerPrompt.AutoSize = true;
            this._lblAnswerPrompt.Location = new System.Drawing.Point(12, 16);
            this._lblAnswerPrompt.Name = "_lblAnswerPrompt";
            this._lblAnswerPrompt.Size = new System.Drawing.Size(85, 13);
            this._lblAnswerPrompt.TabIndex = 0;
            this._lblAnswerPrompt.Text = "I want to answer";
            // 
            // _comboBoxQuestionCount
            // 
            this._comboBoxQuestionCount.FormattingEnabled = true;
            this._comboBoxQuestionCount.Location = new System.Drawing.Point(105, 13);
            this._comboBoxQuestionCount.Name = "_comboBoxQuestionCount";
            this._comboBoxQuestionCount.Size = new System.Drawing.Size(35, 21);
            this._comboBoxQuestionCount.TabIndex = 1;
            // 
            // _lblQuestions
            // 
            this._lblQuestions.AutoSize = true;
            this._lblQuestions.Location = new System.Drawing.Point(156, 16);
            this._lblQuestions.Name = "_lblQuestions";
            this._lblQuestions.Size = new System.Drawing.Size(54, 13);
            this._lblQuestions.TabIndex = 2;
            this._lblQuestions.Text = "Questions";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 145);
            this.Controls.Add(this._lblQuestions);
            this.Controls.Add(this._comboBoxQuestionCount);
            this.Controls.Add(this._lblAnswerPrompt);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblAnswerPrompt;
        private System.Windows.Forms.ComboBox _comboBoxQuestionCount;
        private System.Windows.Forms.Label _lblQuestions;
    }
}