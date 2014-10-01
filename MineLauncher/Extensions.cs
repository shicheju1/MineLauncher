using System;
using System.IO;
using System.Net;
using System.Linq;

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
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }

    }
}
