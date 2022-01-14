using Duck.MediaRemote.Server.Controls;
using Duck.MediaRemote.Server.Properties;
using Duck.MediaRemote.Server.Services;
using EmbedIO;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Forms
{
    public partial class MainForm : BaseForm
    {
        private bool allowVisible = false;
        private bool allowClose = false;

        public MainForm()
        {
            InitializeComponent();
            trayIcon.Icon = Resources.icon_logo_ico;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateWebServer().ConfigureAwait(false);
            lblServerName.Text = "Server: " + Environment.MachineName;
            lsbProfiles.DataSource = ProfileManager.Profiles;
            chbShowRequests.Checked = Settings.Default.ShowRequests;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                Minimize();
                e.Cancel = true;
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!IsHandleCreated)
                {
                    CreateHandle();
                }
            }
            base.SetVisibleCore(value);
        }

        private void ShowRequests_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ShowRequests = chbShowRequests.Checked;
            Settings.Default.Save();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Restore();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var about = new AboutForm())
            {
                about.ShowDialog(this);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowClose = true;
            Application.Exit();
        }

        private async Task CreateWebServer()
        {
            var url = "http://*:9696/";

            Log("Server: " + Environment.MachineName);

            var serverOptions = new WebServerOptions()
                .WithUrlPrefix(url)
                .WithMode(HttpListenerMode.EmbedIO);

            using (var server = new WebServer(serverOptions))
            {
                server.StateChanged += (o, e) => Log("Server: " + e.NewState.ToString());
                server.WithAction("/", HttpVerbs.Get, ctx => RequestHandler.Handle(ctx, RequestLog));
                await server.RunAsync();
            }
        }

        private void Log(string text)
        {
            rtbLog.InvokeIfRequired(() =>
            {
                rtbLog.AppendText(text + "\r\n");
                rtbLog.ScrollToCaret();
                rtbLog.Focus();
            });
        }

        private void RequestLog(string text)
        {
            if (chbShowRequests.Checked)
            {
                Log(text);
            }
        }

        private void Restore()
        {
            allowVisible = true;
            Show();
            Activate();
        }

        private void Minimize()
        {
            Hide();
        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            using (var profileForm = new ProfileForm())
            {
                profileForm.ShowDialog();
            }
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            int index = lsbProfiles.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                ProfileManager.RemoveProfile(ProfileManager.Profiles[index]);
            }
        }

        private void lsbProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lsbProfiles.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                var profile = ProfileManager.Profiles[index];
                using (var profileForm = new ProfileForm(profile))
                {
                    profileForm.ShowDialog();
                }
            }
        }
    }
}
