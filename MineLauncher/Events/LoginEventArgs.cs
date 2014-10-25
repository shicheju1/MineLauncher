using System;

namespace MineLauncher.Events
{
    internal sealed class LoginEventArgs : BaseEventArgs
    {
        
        private LoginEventArgs()
        {
        }

        public LoginEventArgs(string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            base.OnEvent("Login", entryText, logtype);
        }

        public LoginEventArgs(string entryPrefix, string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            base.OnEvent(entryPrefix, entryText, logtype);
        }

    }
}
