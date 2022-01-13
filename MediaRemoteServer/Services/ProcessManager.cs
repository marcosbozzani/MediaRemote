using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Duck.MediaRemote.Server.Services
{
    public class ProcessManager
    {
        public static string GetActiveProcessFileName()
        {
            IntPtr hwnd = GetForegroundWindow();
            if (hwnd == IntPtr.Zero)
            {
                return null;
            }

            GetWindowThreadProcessId(hwnd, out uint pid);
            if (pid == 0)
            {
                return null;
            }

            Process process = Process.GetProcessById((int)pid);
            if (process == null)
            {
                return null;
            }

            return process.ProcessName;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
    }
}
