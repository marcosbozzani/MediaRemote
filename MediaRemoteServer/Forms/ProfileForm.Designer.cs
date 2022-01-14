
namespace Duck.MediaRemote.Server.Forms
{
    partial class ProfileForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hkcPower = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcOutput = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcFullscreen = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcRed = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcGreen = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcYellow = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcBlue = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcPrevious = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcNext = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcRewind = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcPlay = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcForward = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcVolumeDown = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcVolumeUp = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcAudio = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcAudioOff = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcSubtitles = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.hkcSubsOff = new Duck.MediaRemote.Server.Controls.HotkeyControl();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.hkcPower);
            this.flowLayoutPanel1.Controls.Add(this.hkcOutput);
            this.flowLayoutPanel1.Controls.Add(this.hkcFullscreen);
            this.flowLayoutPanel1.Controls.Add(this.hkcRed);
            this.flowLayoutPanel1.Controls.Add(this.hkcGreen);
            this.flowLayoutPanel1.Controls.Add(this.hkcYellow);
            this.flowLayoutPanel1.Controls.Add(this.hkcBlue);
            this.flowLayoutPanel1.Controls.Add(this.hkcPrevious);
            this.flowLayoutPanel1.Controls.Add(this.hkcNext);
            this.flowLayoutPanel1.Controls.Add(this.hkcRewind);
            this.flowLayoutPanel1.Controls.Add(this.hkcPlay);
            this.flowLayoutPanel1.Controls.Add(this.hkcForward);
            this.flowLayoutPanel1.Controls.Add(this.hkcVolumeDown);
            this.flowLayoutPanel1.Controls.Add(this.hkcVolumeUp);
            this.flowLayoutPanel1.Controls.Add(this.hkcAudio);
            this.flowLayoutPanel1.Controls.Add(this.hkcAudioOff);
            this.flowLayoutPanel1.Controls.Add(this.hkcSubtitles);
            this.flowLayoutPanel1.Controls.Add(this.hkcSubsOff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(935, 539);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // hkcPower
            // 
            this.hkcPower.BackColor = System.Drawing.SystemColors.Control;
            this.hkcPower.Hotkey = null;
            this.hkcPower.Location = new System.Drawing.Point(3, 3);
            this.hkcPower.Name = "hkcPower";
            this.hkcPower.Size = new System.Drawing.Size(910, 35);
            this.hkcPower.TabIndex = 0;
            this.hkcPower.Title = "Power";
            this.hkcPower.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcOutput
            // 
            this.hkcOutput.BackColor = System.Drawing.SystemColors.Control;
            this.hkcOutput.Hotkey = null;
            this.hkcOutput.Location = new System.Drawing.Point(3, 44);
            this.hkcOutput.Name = "hkcOutput";
            this.hkcOutput.Size = new System.Drawing.Size(910, 35);
            this.hkcOutput.TabIndex = 1;
            this.hkcOutput.Title = "Output";
            this.hkcOutput.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcFullscreen
            // 
            this.hkcFullscreen.BackColor = System.Drawing.SystemColors.Control;
            this.hkcFullscreen.Hotkey = null;
            this.hkcFullscreen.Location = new System.Drawing.Point(3, 85);
            this.hkcFullscreen.Name = "hkcFullscreen";
            this.hkcFullscreen.Size = new System.Drawing.Size(910, 35);
            this.hkcFullscreen.TabIndex = 2;
            this.hkcFullscreen.Title = "Fullscreen";
            this.hkcFullscreen.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcRed
            // 
            this.hkcRed.BackColor = System.Drawing.SystemColors.Control;
            this.hkcRed.Hotkey = null;
            this.hkcRed.Location = new System.Drawing.Point(3, 126);
            this.hkcRed.Name = "hkcRed";
            this.hkcRed.Size = new System.Drawing.Size(910, 35);
            this.hkcRed.TabIndex = 3;
            this.hkcRed.Title = "Red";
            this.hkcRed.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcGreen
            // 
            this.hkcGreen.BackColor = System.Drawing.SystemColors.Control;
            this.hkcGreen.Hotkey = null;
            this.hkcGreen.Location = new System.Drawing.Point(3, 167);
            this.hkcGreen.Name = "hkcGreen";
            this.hkcGreen.Size = new System.Drawing.Size(910, 35);
            this.hkcGreen.TabIndex = 4;
            this.hkcGreen.Title = "Green";
            this.hkcGreen.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcYellow
            // 
            this.hkcYellow.BackColor = System.Drawing.SystemColors.Control;
            this.hkcYellow.Hotkey = null;
            this.hkcYellow.Location = new System.Drawing.Point(3, 208);
            this.hkcYellow.Name = "hkcYellow";
            this.hkcYellow.Size = new System.Drawing.Size(910, 35);
            this.hkcYellow.TabIndex = 5;
            this.hkcYellow.Title = "Yellow";
            this.hkcYellow.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcBlue
            // 
            this.hkcBlue.BackColor = System.Drawing.SystemColors.Control;
            this.hkcBlue.Hotkey = null;
            this.hkcBlue.Location = new System.Drawing.Point(3, 249);
            this.hkcBlue.Name = "hkcBlue";
            this.hkcBlue.Size = new System.Drawing.Size(910, 35);
            this.hkcBlue.TabIndex = 6;
            this.hkcBlue.Title = "Blue";
            this.hkcBlue.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcPrevious
            // 
            this.hkcPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.hkcPrevious.Hotkey = null;
            this.hkcPrevious.Location = new System.Drawing.Point(3, 290);
            this.hkcPrevious.Name = "hkcPrevious";
            this.hkcPrevious.Size = new System.Drawing.Size(910, 35);
            this.hkcPrevious.TabIndex = 7;
            this.hkcPrevious.Title = "Previous";
            this.hkcPrevious.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcNext
            // 
            this.hkcNext.BackColor = System.Drawing.SystemColors.Control;
            this.hkcNext.Hotkey = null;
            this.hkcNext.Location = new System.Drawing.Point(3, 331);
            this.hkcNext.Name = "hkcNext";
            this.hkcNext.Size = new System.Drawing.Size(910, 35);
            this.hkcNext.TabIndex = 8;
            this.hkcNext.Title = "Next";
            this.hkcNext.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcRewind
            // 
            this.hkcRewind.BackColor = System.Drawing.SystemColors.Control;
            this.hkcRewind.Hotkey = null;
            this.hkcRewind.Location = new System.Drawing.Point(3, 372);
            this.hkcRewind.Name = "hkcRewind";
            this.hkcRewind.Size = new System.Drawing.Size(910, 35);
            this.hkcRewind.TabIndex = 9;
            this.hkcRewind.Title = "Rewind";
            this.hkcRewind.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcPlay
            // 
            this.hkcPlay.BackColor = System.Drawing.SystemColors.Control;
            this.hkcPlay.Hotkey = null;
            this.hkcPlay.Location = new System.Drawing.Point(3, 413);
            this.hkcPlay.Name = "hkcPlay";
            this.hkcPlay.Size = new System.Drawing.Size(910, 35);
            this.hkcPlay.TabIndex = 10;
            this.hkcPlay.Title = "Play";
            this.hkcPlay.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcForward
            // 
            this.hkcForward.BackColor = System.Drawing.SystemColors.Control;
            this.hkcForward.Hotkey = null;
            this.hkcForward.Location = new System.Drawing.Point(3, 454);
            this.hkcForward.Name = "hkcForward";
            this.hkcForward.Size = new System.Drawing.Size(910, 35);
            this.hkcForward.TabIndex = 11;
            this.hkcForward.Title = "Forward";
            this.hkcForward.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcVolumeDown
            // 
            this.hkcVolumeDown.BackColor = System.Drawing.SystemColors.Control;
            this.hkcVolumeDown.Hotkey = null;
            this.hkcVolumeDown.Location = new System.Drawing.Point(3, 495);
            this.hkcVolumeDown.Name = "hkcVolumeDown";
            this.hkcVolumeDown.Size = new System.Drawing.Size(910, 35);
            this.hkcVolumeDown.TabIndex = 12;
            this.hkcVolumeDown.Title = "Volume Down";
            this.hkcVolumeDown.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcVolumeUp
            // 
            this.hkcVolumeUp.BackColor = System.Drawing.SystemColors.Control;
            this.hkcVolumeUp.Hotkey = null;
            this.hkcVolumeUp.Location = new System.Drawing.Point(3, 536);
            this.hkcVolumeUp.Name = "hkcVolumeUp";
            this.hkcVolumeUp.Size = new System.Drawing.Size(910, 35);
            this.hkcVolumeUp.TabIndex = 13;
            this.hkcVolumeUp.Title = "Volume Up";
            this.hkcVolumeUp.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcAudio
            // 
            this.hkcAudio.BackColor = System.Drawing.SystemColors.Control;
            this.hkcAudio.Hotkey = null;
            this.hkcAudio.Location = new System.Drawing.Point(3, 577);
            this.hkcAudio.Name = "hkcAudio";
            this.hkcAudio.Size = new System.Drawing.Size(910, 35);
            this.hkcAudio.TabIndex = 14;
            this.hkcAudio.Title = "Audio";
            this.hkcAudio.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcAudioOff
            // 
            this.hkcAudioOff.BackColor = System.Drawing.SystemColors.Control;
            this.hkcAudioOff.Hotkey = null;
            this.hkcAudioOff.Location = new System.Drawing.Point(3, 618);
            this.hkcAudioOff.Name = "hkcAudioOff";
            this.hkcAudioOff.Size = new System.Drawing.Size(910, 35);
            this.hkcAudioOff.TabIndex = 15;
            this.hkcAudioOff.Title = "Audio Off";
            this.hkcAudioOff.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcSubtitles
            // 
            this.hkcSubtitles.BackColor = System.Drawing.SystemColors.Control;
            this.hkcSubtitles.Hotkey = null;
            this.hkcSubtitles.Location = new System.Drawing.Point(3, 659);
            this.hkcSubtitles.Name = "hkcSubtitles";
            this.hkcSubtitles.Size = new System.Drawing.Size(910, 35);
            this.hkcSubtitles.TabIndex = 16;
            this.hkcSubtitles.Title = "Subtitles";
            this.hkcSubtitles.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // hkcSubsOff
            // 
            this.hkcSubsOff.BackColor = System.Drawing.SystemColors.Control;
            this.hkcSubsOff.Hotkey = null;
            this.hkcSubsOff.Location = new System.Drawing.Point(3, 700);
            this.hkcSubsOff.Name = "hkcSubsOff";
            this.hkcSubsOff.Size = new System.Drawing.Size(910, 35);
            this.hkcSubsOff.TabIndex = 17;
            this.hkcSubsOff.Title = "Subs Off";
            this.hkcSubsOff.HotkeyChanged += new System.EventHandler(this.HotkeyChanged);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 29);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(129, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(410, 32);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 585);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfileForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileForm_FormClosed);
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.HotkeyControl hkcPower;
        private Controls.HotkeyControl hkcOutput;
        private Controls.HotkeyControl hkcFullscreen;
        private Controls.HotkeyControl hkcRed;
        private Controls.HotkeyControl hkcGreen;
        private Controls.HotkeyControl hkcYellow;
        private Controls.HotkeyControl hkcBlue;
        private Controls.HotkeyControl hkcPrevious;
        private Controls.HotkeyControl hkcNext;
        private Controls.HotkeyControl hkcRewind;
        private Controls.HotkeyControl hkcPlay;
        private Controls.HotkeyControl hkcForward;
        private Controls.HotkeyControl hkcVolumeDown;
        private Controls.HotkeyControl hkcVolumeUp;
        private Controls.HotkeyControl hkcAudio;
        private Controls.HotkeyControl hkcAudioOff;
        private Controls.HotkeyControl hkcSubtitles;
        private Controls.HotkeyControl hkcSubsOff;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
    }
}