using Duck.MediaRemote.Server.Devices;
using System.Text;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Models
{
    public class Hotkey
    {
        public Hotkey()
        {

        }

        public Hotkey(Keys key)
        {
            Key = key;
        }

        public Hotkey Clone()
        {
            return new Hotkey
            {
                Key = Key,
                Ctrl = Ctrl,
                Alt = Alt,
                Shift = Shift,
                Win = Win
            };
        }

        public Keys Key { get; set; }
        public bool Ctrl { get; set; }
        public bool Alt { get; set; }
        public bool Shift { get; set; }
        public bool Win { get; set; }

        public override string ToString()
        {
            if (Key == Keys.None)
            {
                return Keys.None.ToString();
            }

            var builder = new StringBuilder();
            if (Ctrl)
            {
                builder.Append("Ctrl+");
            }
            if (Alt)
            {
                builder.Append("Alt+");
            }
            if (Shift)
            {
                builder.Append("Shift+");
            }
            if (Win)
            {
                builder.Append("Win+");
            }
            builder.Append(Keyboard.GetKeyName(Key));

            return builder.ToString();
        }
    }
}
