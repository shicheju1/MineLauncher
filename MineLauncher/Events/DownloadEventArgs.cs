using System;

namespace MineLauncher.Events
{
    internal sealed class DownloadEventArgs : EventArgs
    {

        private int private_downloadmax;
        private int private_downloadcurr;
        private string private_downloadingfile;

        public int DownloadMaximum { get { return this.private_downloadmax; } }
        public int DownloadCurrent { get { return this.private_downloadcurr; } }
        public string DownloadingFile { get { return this.private_downloadingfile; } }
        
        public DownloadEventArgs(string entryText, int max, int curr, string file)
        {
            private_downloadcurr = curr;
            private_downloadmax = max;
            private_downloadingfile = file;
        }

        public DownloadEventArgs(string entryPrefix, string entryText, int max, int curr, string file)
        {
            private_downloadcurr = curr;
            private_downloadmax = max;
            private_downloadingfile = file;
        }
        
    }
}
