using Duck.MediaRemote.Server.Devices;
using Duck.MediaRemote.Server.Services;
using EmbedIO;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server
{
    public class RequestHandler
    {
        public static async Task Handle(IHttpContext context, Action<string> log)
        {
            int status;
            string content;
            var action = GetAction(context);
            var processName = ProcessManager.GetActiveProcessFileName();
            var profile = ProfileManager.GetActiveProfile(processName);
            var hotkey = profile.GetHotkey(action);

            if (hotkey == null || hotkey.Key == Keys.None)
            {
                profile = ProfileManager.GetDefaultProfile();
                hotkey = profile.GetHotkey(action);
            }

            if (hotkey != null)
            {
                Keyboard.PerformHotkey(hotkey);
                status = 200;
                content = hotkey.ToString();
                log(string.Format("[{0}] {1} = [{2}] {3}", profile, action, processName, content));
            }
            else
            {
                status = 404;
                content = "not found";
                log(string.Format("{0} = {1}", action, content));
            }

            context.Response.StatusCode = status;
            await context.SendStringAsync(content, "text/plain", Encoding.UTF8);
        }

        private static string GetAction(IHttpContext context)
        {
            return context.RequestedPath.Substring(1).Replace("%20", "");
        }
    }
}
