using Duck.MediaRemote.Server.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Duck.MediaRemote.Server.Devices
{
    public class Keyboard
    {
        public static void PressKey(Keys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY, UIntPtr.Zero);
        }

        public static void ReleaseKey(Keys key)
        {
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);
        }

        public static void PerformHotkey(Hotkey hotkey)
        {
            if (hotkey.Key != Keys.None)
            {
                if (hotkey.Ctrl) PressKey(Keys.ControlKey);
                if (hotkey.Alt) PressKey(Keys.Menu);
                if (hotkey.Shift) PressKey(Keys.ShiftKey);
                if (hotkey.Win) PressKey(Keys.LWin);

                PressKey(hotkey.Key);
                ReleaseKey(hotkey.Key);

                if (hotkey.Win) ReleaseKey(Keys.LWin);
                if (hotkey.Shift) ReleaseKey(Keys.ShiftKey);
                if (hotkey.Alt) ReleaseKey(Keys.Menu);
                if (hotkey.Ctrl) ReleaseKey(Keys.ControlKey);
            }
        }

        public static IEnumerable<Keys> GetAllKeys()
        {
            return keysNames.Keys;
        }

        public static string GetKeyName(Keys key)
        {
            var unicode = VirtualKeyToUnicode((uint)key);
            if (unicode == (char)0 || unicode == ' ' || char.IsControl(unicode) || key.ToString()[0] == unicode)
            {
                return GetAllNames(key);
            }
            return string.Format("{0} ({1})", unicode, GetAllNames(key));
        }

        private static char VirtualKeyToUnicode(uint virtualKey)
        {
            var scanCode = MapVirtualKey(virtualKey, MAPVK_VK_TO_VSC);
            var keyState = new byte[255];
            //bool bKeyStateStatus = GetKeyboardState(bKeyState);
            //if (!bKeyStateStatus)
            //    return "";
            int builderSize = 5;
            var builder = new StringBuilder(builderSize);
            var flags = 0u;
            var layout = GetKeyboardLayout(0);

            while (ToUnicodeEx(virtualKey, scanCode, keyState, builder, builderSize, flags, layout) >= 2) ;

            var result = builder.ToString().ToUpperInvariant();

            return result.Length == 1 ? result[0] : (char)0;
        }

        private static string GetAllNames(Keys key)
        {
            if (keysNames.ContainsKey(key))
            {
                return keysNames[key];
            }
            return key.ToString();
        }

        private static Dictionary<Keys, string> keysNames = new Dictionary<Keys, string>();

        static Keyboard()
        {
            var fields = typeof(Keys).GetFields(BindingFlags.Public | BindingFlags.Static);
            foreach (var field in fields)
            {
                var name = field.Name;
                var key = (Keys)field.GetRawConstantValue();
                if (!keysNames.ContainsKey(key))
                {
                    keysNames.Add(key, name);
                }
                else
                {
                    keysNames[key] += " | " + name;
                }
            }
        }

        private const uint KEYEVENTF_EXTENDEDKEY = 0x1;
        private const uint KEYEVENTF_KEYUP = 0x2;
        private const uint MAPVK_VK_TO_VSC = 0x0;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState,
            [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

        [DllImport("user32.dll")]
        private static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        private static extern IntPtr GetKeyboardLayout(uint idThread);
    }
}
