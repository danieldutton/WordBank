namespace WordBank.Presentation
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this._richTextBoxXml = new System.Windows.Forms.RichTextBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _richTextBoxXml
            // 
            this._richTextBoxXml.Location = new System.Drawing.Point(13, 13);
            this._richTextBoxXml.Name = "_richTextBoxXml";
            this._richTextBoxXml.Size = new System.Drawing.Size(259, 237);
            this._richTextBoxXml.TabIndex = 0;
            this._richTextBoxXml.Text = "";
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(215, 256);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(57, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.CancelEdit_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(12, 256);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(57, 23);
            this._btnSave.TabIndex = 2;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this.SaveEdits_Click);
            // 
            // _btnReset
            // 
            this._btnReset.Location = new System.Drawing.Point(152, 256);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(57, 23);
            this._btnReset.TabIndex = 3;
            this._btnReset.Text = "Reset";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this.Undo_Edits_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 285);
            this.Controls.Add(this._btnReset);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._richTextBoxXml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 323);
            this.MinimumSize = new System.Drawing.Size(300, 323);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _richTextBoxXml;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnReset;
    }
}