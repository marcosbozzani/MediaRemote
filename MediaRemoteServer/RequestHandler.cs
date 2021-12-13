using EmbedIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaRemote
{
    class RequestHandler
    {
        private static Dictionary<string, string> commands = new Dictionary<string, string>
        {
            { "ping", "pong" },
            { "seek_backward", "{LEFT}" },
            { "play", " " },
            { "seek_forward", "{RIGHT}" },
            { "volume_down", "{DOWN}" },
            { "audio", "a" },
            { "volume_up", "{UP}" },
            { "skip_backward", "{PGUP}" },
            { "subtitle", "s" },
            { "skip_forward", "{PGDN}" },
        };

        public static async Task Handle(IHttpContext context, Action<string> log)
        {
            var status = 404;
            var content = "not found";
            
            var action = context.RequestedPath.Substring(1);
            if (commands.ContainsKey(action))
            {
                var command = commands[action];
                if (command != "ping")
                {
                    log(command);
                    SendKeys.SendWait(command);
                }

                status = 200;
                content = command;
            }

            context.Response.StatusCode = status;
            await context.SendStringAsync(content, "text/plain", Encoding.UTF8);
        }
    }
}
