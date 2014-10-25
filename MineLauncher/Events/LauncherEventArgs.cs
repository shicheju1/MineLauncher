using System;

namespace MineLauncher.Events
{
    internal sealed class LauncherEventArgs : BaseEventArgs
    {
        
        private LauncherEventArgs()
        {
        }

        public LauncherEventArgs(string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            base.OnEvent("Launcher", entryText, logtype);
        }

        public LauncherEventArgs(string entryPrefix, string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            base.OnEvent(entryPrefix, entryText, logtype);
        }

    }
}
