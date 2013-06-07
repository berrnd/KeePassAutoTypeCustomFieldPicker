namespace AutoTypeCustomFieldPicker
{
    partial class DlgPickCustomField
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
            this.label_PlaceholderInfo = new System.Windows.Forms.Label();
            this.listBox_CustomFields = new System.Windows.Forms.ListBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PlaceholderInfo
            // 
            this.label_PlaceholderInfo.AutoSize = true;
            this.label_PlaceholderInfo.Location = new System.Drawing.Point(12, 9);
            this.label_PlaceholderInfo.Name = "label_PlaceholderInfo";
            this.label_PlaceholderInfo.Size = new System.Drawing.Size(196, 13);
            this.label_PlaceholderInfo.TabIndex = 0;
            this.label_PlaceholderInfo.Text = "Pick a custom field for placeholder \"{0}\"";
            // 
            // listBox_CustomFields
            // 
            this.listBox_CustomFields.FormattingEnabled = true;
            this.listBox_CustomFields.Location = new System.Drawing.Point(15, 25);
            this.listBox_CustomFields.Name = "listBox_CustomFields";
            this.listBox_CustomFields.Size = new System.Drawing.Size(276, 160);
            this.listBox_CustomFields.TabIndex = 1;
            this.listBox_CustomFields.DoubleClick += new System.EventHandler(this.listBox_CustomFields_DoubleClick);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(216, 191);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(135, 191);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // DlgPickCustomField
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(309, 229);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.listBox_CustomFields);
            this.Controls.Add(this.label_PlaceholderInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgPickCustomField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickCustomField | KeePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PlaceholderInfo;
        private System.Windows.Forms.ListBox listBox_CustomFields;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
    }
}