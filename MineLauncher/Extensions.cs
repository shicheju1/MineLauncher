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
        
    }
}
