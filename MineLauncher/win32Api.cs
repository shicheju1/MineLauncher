using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace MineLauncher.Win32Api
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal class MEMORYSTATUSEX
    {
        public uint dwLength;
        public uint dwMemoryLoad;
        public ulong ullTotalPhys;
        public ulong ullAvailPhys;
        public ulong ullTotalPageFile;
        public ulong ullAvailPageFile;
        public ulong ullTotalVirtual;
        public ulong ullAvailVirtual;
        public ulong ullAvailExtendedVirtual;
        public MEMORYSTATUSEX()
        {
            this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
        }
    }

    internal class NativesMethods
    {

        internal const int WM_SETICON = 0x80;
        internal const int ICON_SMALL = 0;
        internal const int ICON_BIG = 1;

        [DllImport("user32.dll")]
        internal static extern int SendMessage(IntPtr hwnd, int message, int wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        internal static extern void ReleaseDC(IntPtr dc);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AllocConsole();

    }

}
