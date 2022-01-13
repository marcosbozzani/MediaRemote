
namespace Duck.MediaRemote.Server.Controls
{
    partial class HotkeyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chbCtrl = new Duck.MediaRemote.Server.Controls.CheckBox();
            this.chbAlt = new Duck.MediaRemote.Server.Controls.CheckBox();
            this.chbShift = new Duck.MediaRemote.Server.Controls.CheckBox();
            this.chbWin = new Duck.MediaRemote.Server.Controls.CheckBox();
            this.SuspendLayout();
            // 
            // txtHotkey
            // 
            this.txtHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkey.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotkey.Location = new System.Drawing.Point(126, 3);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.Size = new System.Drawing.Size(410, 32);
            this.txtHotkey.TabIndex = 11;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSelect.Location = new System.Drawing.Point(542, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(64, 31);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 3);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 29);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.Location = new System.Drawing.Point(612, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 31);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chbCtrl
            // 
            this.chbCtrl.BoxPadding = 3;
            this.chbCtrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCtrl.Location = new System.Drawing.Point(674, 3);
            this.chbCtrl.Name = "chbCtrl";
            this.chbCtrl.Size = new System.Drawing.Size(65, 31);
            this.chbCtrl.TabIndex = 15;
            this.chbCtrl.Text = "Ctrl";
            this.chbCtrl.UseVisualStyleBackColor = true;
            this.chbCtrl.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // chbAlt
            // 
            this.chbAlt.BoxPadding = 3;
            this.chbAlt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAlt.Location = new System.Drawing.Point(732, 3);
            this.chbAlt.Name = "chbAlt";
            this.chbAlt.Size = new System.Drawing.Size(65, 31);
            this.chbAlt.TabIndex = 16;
            this.chbAlt.Text = "Alt";
            this.chbAlt.UseVisualStyleBackColor = true;
            this.chbAlt.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // chbShift
            // 
            this.chbShift.BoxPadding = 3;
            this.chbShift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShift.Location = new System.Drawing.Point(784, 3);
            this.chbShift.Name = "chbShift";
            this.chbShift.Size = new System.Drawing.Size(65, 31);
            this.chbShift.TabIndex = 17;
            this.chbShift.Text = "Shift";
            this.chbShift.UseVisualStyleBackColor = true;
            this.chbShift.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // chbWin
            // 
            this.chbWin.BoxPadding = 3;
            this.chbWin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbWin.Location = new System.Drawing.Point(849, 3);
            this.chbWin.Name = "chbWin";
            this.chbWin.Size = new System.Drawing.Size(65, 31);
            this.chbWin.TabIndex = 18;
            this.chbWin.Text = "Win";
            this.chbWin.UseVisualStyleBackColor = true;
            this.chbWin.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // HotkeyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.chbWin);
            this.Controls.Add(this.chbShift);
            this.Controls.Add(this.chbAlt);
            this.Controls.Add(this.chbCtrl);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtHotkey);
            this.Name = "HotkeyControl";
            this.Size = new System.Drawing.Size(910, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private CheckBox chbCtrl;
        private CheckBox chbAlt;
        private CheckBox chbShift;
        private CheckBox chbWin;
    }
}
