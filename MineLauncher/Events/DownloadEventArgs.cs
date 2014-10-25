using System;

namespace MineLauncher.Events
{
    internal sealed class DownloadEventArgs : BaseEventArgs
    {

        private int private_downloadmax;
        private int private_downloadcurr;
        private string private_downloadingfile;

        public int DownloadMaximum { get { return this.private_downloadmax; } }
        public int DownloadCurrent { get { return this.private_downloadcurr; } }
        public string DownloadingFile { get { return this.private_downloadingfile; } }

        private DownloadEventArgs()
        {
        }

        public DownloadEventArgs(string entryText, int max, int curr, string file, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            private_downloadcurr = curr;
            private_downloadmax = max;
            private_downloadingfile = file;

            base.OnEvent("Download", entryText, logtype);
        }

        public DownloadEventArgs(string entryPrefix, string entryText, int max, int curr, string file, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            private_downloadcurr = curr;
            private_downloadmax = max;
            private_downloadingfile = file;

            base.OnEvent(entryPrefix, entryText, logtype);
        }
        
    }
}
