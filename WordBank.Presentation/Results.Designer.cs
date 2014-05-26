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
            this.SuspendLayout();
            // 
            // _panelResults
            // 
            this._panelResults.AutoScroll = true;
            this._panelResults.Location = new System.Drawing.Point(13, 13);
            this._panelResults.Name = "_panelResults";
            this._panelResults.Size = new System.Drawing.Size(406, 480);
            this._panelResults.TabIndex = 0;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this._panelResults);
            this.Name = "Results";
            this.Text = "Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panelResults;
    }
}