using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Models
{
    public class Profile : INotifyPropertyChanged
    {
        private string name = string.Empty;
        private static readonly IDictionary<string, PropertyInfo> hotkeys;

        static Profile()
        {
            hotkeys = typeof(Profile)
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.PropertyType == typeof(Hotkey))
                .ToDictionary(p => p.Name, p => p);
        }

        public Hotkey GetHotkey(string name)
        {
            if (hotkeys.TryGetValue(name, out var property))
            {
                return (Hotkey)property.GetValue(this);
            }
            return null;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Title { get; set; } = string.Empty;
        public Hotkey Power { get; set; } = new Hotkey(Keys.None);
        public Hotkey Output { get; set; } = new Hotkey(Keys.None);
        public Hotkey Fullscreen { get; set; } = new Hotkey(Keys.None);
        public Hotkey Red { get; set; } = new Hotkey(Keys.None);
        public Hotkey Green { get; set; } = new Hotkey(Keys.None);
        public Hotkey Yellow { get; set; } = new Hotkey(Keys.None);
        public Hotkey Blue { get; set; } = new Hotkey(Keys.None);
        public Hotkey Previous { get; set; } = new Hotkey(Keys.None);
        public Hotkey Next { get; set; } = new Hotkey(Keys.None);
        public Hotkey Rewind { get; set; } = new Hotkey(Keys.None);
        public Hotkey Play { get; set; } = new Hotkey(Keys.None);
        public Hotkey Forward { get; set; } = new Hotkey(Keys.None);
        public Hotkey VolumeDown { get; set; } = new Hotkey(Keys.None);
        public Hotkey VolumeUp { get; set; } = new Hotkey(Keys.None);
        public Hotkey Audio { get; set; } = new Hotkey(Keys.None);
        public Hotkey AudioOff { get; set; } = new Hotkey(Keys.None);
        public Hotkey Subtitles { get; set; } = new Hotkey(Keys.None);
        public Hotkey SubsOff { get; set; } = new Hotkey(Keys.None);

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Profile Clone()
        {
            return new Profile
            {
                Power = Power.Clone(),
                Output = Output.Clone(),
                Fullscreen = Fullscreen.Clone(),
                Red = Red.Clone(),
                Green = Green.Clone(),
                Yellow = Yellow.Clone(),
                Blue = Blue.Clone(),
                Previous = Previous.Clone(),
                Next = Next.Clone(),
                Rewind = Rewind.Clone(),
                Play = Play.Clone(),
                Forward = Forward.Clone(),
                VolumeDown = VolumeDown.Clone(),
                VolumeUp = VolumeUp.Clone(),
                Audio = Audio.Clone(),
                AudioOff = AudioOff.Clone(),
                Subtitles = Subtitles.Clone(),
                SubsOff = SubsOff.Clone()
            };
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? "(default)" : Name;
        }
    }
}
