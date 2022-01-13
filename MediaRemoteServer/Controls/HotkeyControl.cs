using Duck.MediaRemote.Server.Models;
using System;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Controls
{
    public partial class HotkeyControl : UserControl
    {
        public HotkeyControl()
        {
            InitializeComponent();
        }

        private Hotkey hotkey;
        public Hotkey Hotkey
        {
            get { return hotkey; }
            set
            {
                hotkey = value;
                if (hotkey != null)
                {
                    chbCtrl.Checked = hotkey.Ctrl;
                    chbAlt.Checked = hotkey.Alt;
                    chbShift.Checked = hotkey.Shift;
                    chbWin.Checked = hotkey.Win;
                    UpdateHotkey(hotkey.Key);
                }
            }
        }

        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public void UpdateHotkey(Keys key)
        {
            Hotkey.Key = key;
            Hotkey.Ctrl = chbCtrl.Checked;
            Hotkey.Alt = chbAlt.Checked;
            Hotkey.Shift = chbShift.Checked;
            Hotkey.Win = chbWin.Checked;
            txtHotkey.Text = Hotkey.ToString();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (var dialog = new HotkeySelector())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    UpdateHotkey(dialog.SelectedKey);
                }
            }
        }

        private void chb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHotkey(Hotkey.Key);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chbCtrl.Checked = false;
            chbAlt.Checked = false;
            chbShift.Checked = false;
            chbWin.Checked = false;
            UpdateHotkey(Keys.None);
        }
    }
}
