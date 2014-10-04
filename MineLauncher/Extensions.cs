using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Windows.Forms;

namespace MineLauncher
{
    public static class Extensions
    {

        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public static void CreateDirectoryStructure(this DirectoryInfo d)
        {
            string currpath = "";
            foreach (string dir in d.FullName.Split('\\'))
            {
                currpath += dir + "\\";
                if (!Directory.Exists(currpath))
                    Directory.CreateDirectory(currpath);
            }
        }

        public static bool RemoteExists(this WebClient d, string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                request.Method = "HEAD";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }

        public static void SafeInvoke(this Control uiElement, Action updater, bool forceSynchronous = true)
        {
            if (uiElement == null)
            {
                throw new ArgumentNullException("uiElement");
            }

            if (uiElement.InvokeRequired)
            {
                if (forceSynchronous)
                {
                    try
                    {
                        uiElement.Invoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                    }
                    catch (ObjectDisposedException)
                    {
                    }
                }
                else
                {
                    try
                    {
                        uiElement.BeginInvoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                    }
                    catch (ObjectDisposedException)
                    {
                    }
                }
            }
            else
            {
                if (!uiElement.IsDisposed)
                {
                    updater();
                }
            }
        }

        public static string GetOSFullName(this OperatingSystem os)
        {
            string name = "Unknow";

            switch (os.Version.Major)
            {
                case 3:
                    name = "Windows NT 3.51";
                    break;
                case 4:
                    name = "Windows NT 4.0 \"Cairo\"";
                    break;
                case 5:
                    if (os.Version.Minor == 0)
                        name = "Windows 2000 \"Memphis NT\"";
                    else
                        name = "Windows XP \"Whistler\"";
                    break;
                case 6:
                    if (os.Version.Minor == 0)
                        name = "Windows Vista \"Longhorn\"";
                    else if (os.Version.Minor == 1)
                        name = "Windows 7 \"Vienna\"";
                    else if (os.Version.Minor == 2)
                        name = "Windows 8 \"8\"";
                    else if (os.Version.Minor == 3)
                        name = "Windows 8.1 \"Blue\"";
                    else if (os.Version.Minor == 4)
                        name = "Windows 10 \"Threshold\" - Be careful when testing ;)"; /* Supported since 04.10.2014 :D */
                    break; 
            }

            return name;
        }
        
    }
}
