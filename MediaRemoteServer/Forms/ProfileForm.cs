using Duck.MediaRemote.Server.Controls;
using Duck.MediaRemote.Server.Models;
using System;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Forms
{
    public partial class ProfileForm : BaseForm, IMessageFilter
    {
        private readonly Profile profile;
        private readonly bool isDefaultProfile;

        public ProfileForm(Profile profile, bool isDefaultProfile)
        {
            InitializeComponent();
            this.profile = profile;
            this.isDefaultProfile = isDefaultProfile;

            if (isDefaultProfile)
            {
                txtName.Enabled = false;
            }

            txtName.Text = isDefaultProfile ? profile.ToString() : profile.Name;
            hkcPower.Hotkey = profile.Power;
            hkcOutput.Hotkey = profile.Output;
            hkcFullscreen.Hotkey = profile.Fullscreen;
            hkcRed.Hotkey = profile.Red;
            hkcGreen.Hotkey = profile.Green;
            hkcYellow.Hotkey = profile.Yellow;
            hkcBlue.Hotkey = profile.Blue;
            hkcPrevious.Hotkey = profile.Previous;
            hkcNext.Hotkey = profile.Next;
            hkcRewind.Hotkey = profile.Rewind;
            hkcPlay.Hotkey = profile.Play;
            hkcForward.Hotkey = profile.Forward;
            hkcVolumeDown.Hotkey = profile.VolumeDown;
            hkcVolumeUp.Hotkey = profile.VolumeUp;
            hkcAudio.Hotkey = profile.Audio;
            hkcAudioOff.Hotkey = profile.AudioOff;
            hkcSubtitles.Hotkey = profile.Subtitles;
            hkcSubsOff.Hotkey = profile.SubsOff;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            Application.AddMessageFilter(this);
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isDefaultProfile && profile.Name == string.Empty)
            {
                MessageBox.Show("Name cannot be empty", "Profile");
                e.Cancel = true;
            }
        }

        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.RemoveMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message message)
        {
            const int WM_KEYDOWN = 0x0100;
            const int WM_SYSKEYDOWN = 0x0104;

            var control = FromHandle(message.HWnd);
            if (control != null && control.FindForm() == this)
            {
                if (message.Msg == WM_KEYDOWN || message.Msg == WM_SYSKEYDOWN)
                {
                    if (ActiveControl is HotkeyControl hotkeyControl)
                    {
                        var key = (Keys)message.WParam.ToInt32();
                        hotkeyControl.UpdateHotkey(key);
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!isDefaultProfile)
            {
                profile.Name = txtName.Text.Trim();
            }
        }
    }
}
