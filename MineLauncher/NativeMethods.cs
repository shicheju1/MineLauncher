using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

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

    internal class NativeMethods
    {

        internal const int WM_SETICON = 0x80;
        internal const int ICON_SMALL = 0;
        internal const int ICON_BIG = 1;

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        [DllImport("Kernel32.dll")]
        internal static extern bool AllocConsole();
    
        [DllImport("Wininet.dll", CharSet = CharSet.Auto)]
        public static extern bool InternetGetConnectedState(int lpdwFlags, int dwReserved);
        
        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        
    }

}
