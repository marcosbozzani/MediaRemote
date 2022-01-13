using Duck.MediaRemote.Server.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SingleInstanceController controller = new SingleInstanceController();
            controller.Run(args);
        }
    }

    class SingleInstanceController : WindowsFormsApplicationBase
    {
        public SingleInstanceController()
        {
            IsSingleInstance = true;
        }

        protected override void OnCreateMainForm()
        {
            MainForm = new MainForm();
        }
    }

    static partial class BuildConfig
    {
        public static readonly string BuildDate;
        public static readonly string BuildType;
    }
}
