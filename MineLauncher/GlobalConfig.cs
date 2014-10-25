using System;
using System.Collections.Generic;
using System.IO;

namespace MineLauncher
{
    public class GlobalConfig
    {
        
        public static string AppDataPath
        {
            get
            {
                string architcture = Environment.Is64BitOperatingSystem ? "64" : "86";
                if (File.Exists(Directory.GetCurrentDirectory() + "\\app.prop" + architcture))
                {
                    return File.ReadAllLines(Directory.GetCurrentDirectory() + "\\app.prop" + architcture)[0]
                        .Replace("%CD%", Directory.GetCurrentDirectory())
                        .Replace("%BD%", Path.GetPathRoot(Directory.GetCurrentDirectory()))
                        .Replace("%AUTO%", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                }

                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            }
        }

        public static string GetJavaPath(string profile_jvm)
        {
            string architcture = Environment.Is64BitOperatingSystem ? "64" : "86";
            if (File.Exists(Directory.GetCurrentDirectory() + "\\app.prop" + architcture))
            {
                return File.ReadAllLines(Directory.GetCurrentDirectory() + "\\app.prop" + architcture)[1]
                        .Replace("%CD%", Directory.GetCurrentDirectory())
                        .Replace("%BD%", Path.GetPathRoot(Directory.GetCurrentDirectory()))
                        .Replace("%AUTO%", Environment.GetEnvironmentVariable("JAVA_HOME", EnvironmentVariableTarget.User));
            }

            return profile_jvm;
        }

    }
}
