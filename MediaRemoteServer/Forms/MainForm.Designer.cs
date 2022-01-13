
namespace Duck.MediaRemote.Server.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbProfiles = new System.Windows.Forms.ListBox();
            this.panelLog = new System.Windows.Forms.Panel();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.btnRemoveProfile = new System.Windows.Forms.Button();
            this.lblProfiles = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.chbShowRequests = new Duck.MediaRemote.Server.Controls.CheckBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.trayIconMenu.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.Window;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(542, 412);
            this.rtbLog.TabIndex = 1;
            this.rtbLog.Text = "";
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Text = "Media Remote";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayIconMenu.Name = "contextMenuStrip";
            this.trayIconMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lsbProfiles
            // 
            this.lsbProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbProfiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbProfiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbProfiles.FormattingEnabled = true;
            this.lsbProfiles.IntegralHeight = false;
            this.lsbProfiles.ItemHeight = 21;
            this.lsbProfiles.Location = new System.Drawing.Point(562, 33);
            this.lsbProfiles.Name = "lsbProfiles";
            this.lsbProfiles.Size = new System.Drawing.Size(260, 414);
            this.lsbProfiles.TabIndex = 3;
            this.lsbProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbProfiles_MouseDoubleClick);
            // 
            // panelLog
            // 
            this.panelLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLog.Controls.Add(this.rtbLog);
            this.panelLog.Location = new System.Drawing.Point(12, 33);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(544, 414);
            this.panelLog.TabIndex = 4;
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.AutoSize = true;
            this.btnAddProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProfile.Location = new System.Drawing.Point(562, 453);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(125, 31);
            this.btnAddProfile.TabIndex = 5;
            this.btnAddProfile.Text = "Add";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // btnRemoveProfile
            // 
            this.btnRemoveProfile.AutoSize = true;
            this.btnRemoveProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProfile.Location = new System.Drawing.Point(697, 453);
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            this.btnRemoveProfile.Size = new System.Drawing.Size(125, 31);
            this.btnRemoveProfile.TabIndex = 6;
            this.btnRemoveProfile.Text = "Remove";
            this.btnRemoveProfile.UseVisualStyleBackColor = true;
            this.btnRemoveProfile.Click += new System.EventHandler(this.btnRemoveProfile_Click);
            // 
            // lblProfiles
            // 
            this.lblProfiles.AutoSize = true;
            this.lblProfiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfiles.Location = new System.Drawing.Point(558, 9);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(62, 21);
            this.lblProfiles.TabIndex = 7;
            this.lblProfiles.Text = "Profiles";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(8, 9);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(36, 21);
            this.lblLog.TabIndex = 8;
            this.lblLog.Text = "Log";
            // 
            // chbShowRequests
            // 
            this.chbShowRequests.BoxPadding = 3;
            this.chbShowRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowRequests.Location = new System.Drawing.Point(419, 454);
            this.chbShowRequests.Name = "chbShowRequests";
            this.chbShowRequests.Size = new System.Drawing.Size(136, 31);
            this.chbShowRequests.TabIndex = 10;
            this.chbShowRequests.Text = "Show Requests";
            this.chbShowRequests.UseVisualStyleBackColor = true;
            this.chbShowRequests.CheckedChanged += new System.EventHandler(this.ShowRequests_CheckedChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(9, 453);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(300, 31);
            this.lblServerName.TabIndex = 11;
            this.lblServerName.Text = "Server:";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 497);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.chbShowRequests);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblProfiles);
            this.Controls.Add(this.btnRemoveProfile);
            this.Controls.Add(this.btnAddProfile);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.lsbProfiles);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.trayIconMenu.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox lsbProfiles;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.Button btnRemoveProfile;
        private System.Windows.Forms.Label lblProfiles;
        private System.Windows.Forms.Label lblLog;
        private Controls.CheckBox chbShowRequests;
        private System.Windows.Forms.Label lblServerName;
    }
}

