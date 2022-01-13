using Duck.MediaRemote.Server.Devices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Controls
{
    public partial class HotkeySelector : BaseForm
    {
        private class KeyAdapter
        {
            public Keys Key { get; private set; }

            public KeyAdapter(Keys key)
            {
                Key = key;
            }

            public override string ToString()
            {
                return Keyboard.GetKeyName(Key);
            }
        }

        private static KeyAdapter[] keyAdapters =
            Keyboard.GetAllKeys().Select(key => new KeyAdapter(key)).ToArray();

        public Keys SelectedKey { get; private set; }

        public HotkeySelector()
        {
            InitializeComponent();
            cmbKey.Items.AddRange(keyAdapters);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SetResult();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                return SetResult();
            }
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private bool SetResult()
        {
            if (cmbKey.SelectedItem != null)
            {
                SelectedKey = ((KeyAdapter)cmbKey.SelectedItem).Key;
                DialogResult = DialogResult.OK;
                return true;
            }
            return false;
        }

        private void KeySelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
