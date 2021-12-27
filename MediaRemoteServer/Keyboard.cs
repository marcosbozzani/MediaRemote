using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MediaRemote
{
    public class Keyboard
    {
        private const uint KEYEVENTF_EXTENDEDKEY = 0x1;
        private const uint KEYEVENTF_KEYUP = 0x2;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        public static void KeyDown(Keys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY, UIntPtr.Zero);
        }

        public static void KeyUp(Keys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);
        }
    }
}
