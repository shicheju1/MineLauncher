using System;
using System.IO;

namespace MineLauncher.Events
{

    public enum EventLogType
    {
        DateAndPrefix,
        Date,
        Prefix,
        None
    }

    public class BaseEventArgs : EventArgs
    {

        private string log_prefix = "MineLauncher";
        private string log_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\logs\\";

        private string private_entry;
        private string private_entrywithoutdate;

        public string Entry { get { return this.private_entry; } }
        public string EntryWithoutDate { get { return this.private_entrywithoutdate; } }

        public BaseEventArgs()
        {
        }

        public BaseEventArgs(string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            OnEvent(entryText, logtype);
        }

        public BaseEventArgs(string entryPrefix, string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            OnEvent(entryPrefix, entryText, logtype);
        }

        public void OnEvent(string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            OnEvent(log_prefix, entryText, logtype);
        }

        public void OnEvent(string entryPrefix, string entryText, EventLogType logtype = EventLogType.DateAndPrefix)
        {
            this.private_entry = "[" + DateTime.Now.ToString() + "][" + entryPrefix.ToUpper() + "] " + entryText;
            this.private_entrywithoutdate = "[" + entryPrefix.ToUpper() + "] " + entryText;

            if (logtype == EventLogType.DateAndPrefix)
            {
                File.AppendAllText(log_path + DateTime.Now.ToShortDateString().Replace(".", "-") + ".log", "[" + DateTime.Now.ToString() + "][" + entryPrefix.ToUpper() + "] " + entryText);
            }
            else if (logtype == EventLogType.Date)
            {
                File.AppendAllText(log_path + DateTime.Now.ToShortDateString().Replace(".", "-") + ".log", "[" + DateTime.Now.ToString() + "][" + entryPrefix.ToUpper() + "] " + entryText);
            }
            else if (logtype == EventLogType.Prefix)
            {
                File.AppendAllText(log_path + DateTime.Now.ToShortDateString().Replace(".", "-") + ".log", "[" + entryPrefix.ToUpper() + "] " + entryText);
            }
            else
            {
                File.AppendAllText(log_path + DateTime.Now.ToShortDateString().Replace(".", "-") + ".log", entryText);
            }
        }

    }

}
