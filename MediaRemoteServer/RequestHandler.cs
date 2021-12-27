using EmbedIO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaRemote
{
    class RequestHandler
    {
        private static Dictionary<string, Keys> commands = new Dictionary<string, Keys>
        {
            { "ping", Keys.None },
            { "seek_backward", Keys.Left },
            { "play", Keys.MediaPlayPause },
            { "seek_forward", Keys.Right },
            { "volume_down", Keys.Down },
            { "audio", Keys.A },
            { "volume_up", Keys.Up },
            { "skip_backward", Keys.MediaPreviousTrack },
            { "subtitle", Keys.S },
            { "skip_forward", Keys.MediaNextTrack },
        };

        public static async Task Handle(IHttpContext context, Action<string> log)
        {
            var status = 404;
            var content = "not found";

            var action = context.RequestedPath.Substring(1);
            if (commands.ContainsKey(action))
            {
                var command = commands[action];
                if (command != Keys.None)
                {
                    log(command.ToString());
                    Keyboard.KeyDown(command);
                }

                status = 200;
                content = command.ToString();
            }

            context.Response.StatusCode = status;
            await context.SendStringAsync(content, "text/plain", Encoding.UTF8);
        }
    }
}
