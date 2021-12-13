using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmbedIO;
using EmbedIO.WebApi;
using MediaRemote.Properties;

namespace MediaRemote
{
    public partial class MainForm : Form
    {
        private bool allowVisible = false;
        private bool allowClose = false;

        public MainForm()
        {
            InitializeComponent();
            _ = CreateWebServer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chkShowCommands.Checked = Settings.Default.ShowCommands;
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

        private void chkShowCommands_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ShowCommands = chkShowCommands.Checked;
            Settings.Default.Save();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Toggle();
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toggle();
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
                server.WithAction("/", HttpVerbs.Get, ctx => RequestHandler.Handle(ctx, CommandLog));
                await server.RunAsync();
            }
        }

        private void Log(string text)
        {
            rtbLog.InvokeIfRequired(() =>
            {
                rtbLog.AppendText(DateTime.Now.ToString("o") + " " + text + "\r\n");
                rtbLog.ScrollToCaret();
            });
        }

        private void CommandLog(string text)
        {
            if (chkShowCommands.Checked)
            {
                Log(text);
            }
        }

        private void Toggle()
        {
            if (Visible)
            {
                Minimize();
            }
            else
            {
                Restore();
            }
        }

        private void Minimize()
        {
            Hide();
            showToolStripMenuItem.Text = "Show";
        }

        private void Restore()
        {
            allowVisible = true;
            Show();
            showToolStripMenuItem.Text = "Hide";
        }
    }
}
