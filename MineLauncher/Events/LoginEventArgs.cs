using System;

namespace MineLauncher.Events
{
    internal sealed class LoginEventArgs : EventArgs
    {               
        
        private string log_prefix = "MineLauncher";
        private string log_path = GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\logs\\";

        private string private_entry;

        public string Entry { get { return this.private_entry; } }
        
        public LoginEventArgs(string content)
        {
            this.private_entry = content;
        }

        public LoginEventArgs(string prefix, string content)
        {
            this.log_prefix = prefix;
            this.private_entry = content;
        }

    }
}
