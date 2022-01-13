
namespace Duck.MediaRemote.Server.Controls
{
    partial class HotkeySelector
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
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKey
            // 
            this.cmbKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(12, 13);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(277, 32);
            this.cmbKey.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.AutoSize = true;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(295, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 34);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // HotkeySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 58);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbKey);
            this.Name = "HotkeySelector";
            this.Text = "Key Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKey;
        private System.Windows.Forms.Button btnSelect;
    }
}