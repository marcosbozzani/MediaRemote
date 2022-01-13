using Duck.MediaRemote.Server.Controls;
using System;

namespace Duck.MediaRemote.Server.Forms
{
    public partial class AboutForm : BaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblBuid.Text = string.Format("{0} ({1})", BuildConfig.BuildDate, BuildConfig.BuildType);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
