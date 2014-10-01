using System;

namespace MineLauncher.Events
{
    public sealed class DownloadEventArgs : BaseEventArgs
    {
        
        private DownloadEventArgs()
        {
        }

        public DownloadEventArgs(string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            base.OnEvent("Download", entryText, logtype);
        }

        public DownloadEventArgs(string entryPrefix, string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            base.OnEvent(entryPrefix, entryText, logtype);
        }
        
    }
}
