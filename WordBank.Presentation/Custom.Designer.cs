namespace WordBank.Presentation
{
    partial class Custom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom));
            this._rTextBoxXml = new System.Windows.Forms.RichTextBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _rTextBoxXml
            // 
            this._rTextBoxXml.Location = new System.Drawing.Point(13, 13);
            this._rTextBoxXml.Name = "_rTextBoxXml";
            this._rTextBoxXml.Size = new System.Drawing.Size(259, 237);
            this._rTextBoxXml.TabIndex = 0;
            this._rTextBoxXml.Text = "";
            this._rTextBoxXml.TextChanged += new System.EventHandler(this.OnTyping_TextChanged);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(13, 257);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.CancelCustomise_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(197, 257);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.SaveCustomise_Click);
            // 
            // _btnReset
            // 
            this._btnReset.Location = new System.Drawing.Point(116, 257);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(75, 23);
            this._btnReset.TabIndex = 3;
            this._btnReset.Text = "Reset";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this._btnReset_Click);
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this._btnReset);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._rTextBoxXml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Custom";
            this.Text = "Custom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _rTextBoxXml;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnReset;
    }
}