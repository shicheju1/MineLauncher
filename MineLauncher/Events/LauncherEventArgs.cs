using System;
using System.Diagnostics;

namespace MineLauncher.Events
{

    internal sealed class LauncherEventArgs : EventArgs
    {        
        
        private string log_prefix = "MineLauncher";
        private string log_path = GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\logs\\";

        private string private_entry;
        private Process private_process;

        public string Entry { get { return this.private_entry; } }

        public Process MinecraftProcess { get { return this.private_process; } }
        
        public LauncherEventArgs(string content, Process proc = null)
        {
            this.private_entry = content;
            this.private_process = proc;
        }

        public LauncherEventArgs(string prefix, string content, Process proc = null)
        {
            this.log_prefix = prefix;
            this.private_entry = content;
            this.private_process = proc;
        }

    }

}
