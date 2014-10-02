using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

using Ionic.Zip;
using Newtonsoft.Json;

using MineLauncher.Events;

namespace MineLauncher.Launcher
{
    public class MinecraftLauncher
    {

        private List<string[]> _libraries = new List<string[]>();

        private string _assetspath = "";
        private string _librariespath = "";
        private string _versionpath = "";
        private string _version = "";

        private string _data_mainClass = "";
        private string _data_minecraftArguments = "";
        private string _data_assets = "";

        private string _profile_gamepath = "";
        private string _profile_jvmfile = "";
        private string _profile_jvmargs = "";

        public delegate void LauncherLogHandler(object sender, LauncherEventArgs e);
        public event LauncherLogHandler OnLauncherLog;

        public MinecraftLauncher(string profilename)
        {
            dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
            Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);

            Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
            foreach (KeyValuePair<string, Dictionary<string, object>> profile in profiles)
            {
                if (profile.Key == profilename)
                {
                    _assetspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\assets\\objects";
                    _librariespath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\libraries";
                    _versionpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\versions\\" + profile.Value["mcversion"];
                    _version = profile.Value["mcversion"].ToString();
                    
                    if (OnLauncherLog != null) OnLauncherLog(this, new LauncherEventArgs("Preparing launcher vor version " + profile.Value["mcversion"]));

                    string _version_json = File.ReadAllText(_versionpath + "\\" + profile.Value["mcversion"] + ".json");
                    Dictionary<string, string[]> rawVersionData = getVersionData(_version_json);
                    
                    _data_mainClass = rawVersionData["mainClass"][0];
                    _data_minecraftArguments = rawVersionData["minecraftArguments"][0];
                    _data_assets = rawVersionData["assets"][0];

                    _profile_gamepath = profile.Value["gamedir"].ToString();
                    _profile_jvmfile = profile.Value["javapath"].ToString();
                    _profile_jvmargs = profile.Value["javaargs"].ToString();

                    foreach (string library in rawVersionData["libraries"])
                    {
                        _libraries.Add(new string[] { 
                            "https://libraries.minecraft.net/" + library.Replace(@"\", "/"), 
                            Path.Combine(_librariespath, library) 
                        });
                    }
                }
            }
        }

        public void LaunchMC(MinecraftSession s, IWin32Window parent, bool offline)
        {
            string cmd = "";
            string ver = _version;
            string mcLocation = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft";

            string mcJava = _profile_jvmfile;
            string mcJavaFile = "javaw";
            string mcLibraries = "-cp ";

            string mojangIntelTrick = "-XX:HeapDumpPath=MojangTricksIntelDriversForPerformance_javaw.exe_minecraft.exe.heapdump";
            string mcNatives = "-Djava.library.path=\"" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\versions\" + ver + @"\" + ver + "-natives-AL74\"";

            if(mcJavaFile == "")
            {
                string mainDrive = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
                if (Environment.Is64BitOperatingSystem)
                {
                    mcJava = mainDrive + @"Windows\SysWOW64\" + mcJavaFile + ".exe";
                    if (!File.Exists(mcJava)) mcJava = mainDrive + @"Windows\System32\" + mcJavaFile + ".exe";
                    if (!File.Exists(mcJava))
                    {
                        MetroFramework.MetroMessageBox.Show(parent, "Java is not installed. Please visit java.com and download the newest version",
                            "Java is not installed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                        return;
                    }
                }
                else
                {
                    mcJava = mainDrive + @"Windows\System32\" + mcJavaFile + ".exe";
                    if (!File.Exists(mcJava))
                    {
                        MetroFramework.MetroMessageBox.Show(parent, "Java is not installed. Please visit java.com and download the newest version",
                            "Java is not installed", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
                        return;
                    }
                }
            }

            foreach (string[] library in _libraries)
            {
                mcLibraries += library[1] + ";";
            }
            
            string mcJar = "\"" + mcLocation + @"\versions\" + ver + @"\" + ver + ".jar\"";

            string mcClass = _data_mainClass;
            string mcArgs = _data_minecraftArguments;

            if(offline)
            {
                mcArgs = mcArgs.Replace("${auth_player_name}", s.OfflineModePlayerName);
            }
            mcArgs = mcArgs.Replace("${auth_player_name}", s.PlayerName);

            if(offline)
            {
                mcArgs = mcArgs.Replace("${auth_session}", "00000000-0000-0000-0000-000000000000:00000000000000000000000000000000");
                mcArgs = mcArgs.Replace("${auth_uuid}", "00000000-0000-0000-0000-000000000000");
                mcArgs = mcArgs.Replace("${auth_access_token}", "00000000000000000000000000000000");
            }

            mcArgs = mcArgs.Replace("${auth_session}", "token:" + s.Session + ":" + s.ProfileID);
            mcArgs = mcArgs.Replace("${auth_uuid}", s.ProfileID);
            mcArgs = mcArgs.Replace("${auth_access_token}", s.Session);
            mcArgs = mcArgs.Replace("${assets_index_name}", _data_assets);
            mcArgs = mcArgs.Replace("${version_name}", ver);
            mcArgs = mcArgs.Replace("${user_properties}", "{}");
            mcArgs = mcArgs.Replace("${game_directory}", "\"" + _profile_gamepath + "\"");
            mcArgs = mcArgs.Replace("${game_assets}", "\"" + mcLocation + "\\assets\\virtual\\legacy\"");
            mcArgs = mcArgs.Replace("${assets_root}", "\"" + mcLocation + "\\assets\"");

            cmd = mojangIntelTrick + " " + _profile_jvmargs + " " + mcNatives + " " + mcLibraries + mcJar + " " + mcClass + " " + mcArgs;

            if (OnLauncherLog != null) OnLauncherLog(this, new LauncherEventArgs("Launcher prepared..."));
            if (OnLauncherLog != null) OnLauncherLog(this, new LauncherEventArgs("Java path: " + mcJava));
            if (OnLauncherLog != null) OnLauncherLog(this, new LauncherEventArgs("Half-Command: " + cmd));

            ProcessStartInfo mcProcessStartInfo = new ProcessStartInfo();
            mcProcessStartInfo.Arguments = cmd;
            mcProcessStartInfo.WorkingDirectory = _profile_gamepath;
            mcProcessStartInfo.FileName = mcJava;
            mcProcessStartInfo.UseShellExecute = false;
            mcProcessStartInfo.RedirectStandardOutput = true;

            Process mcProcess = Process.Start(mcProcessStartInfo);

            StreamReader mcProcessOutputReader = mcProcess.StandardOutput;
            while (!mcProcess.HasExited)
            {
                string read = mcProcessOutputReader.ReadLine();
                if ((read == "") == false || (read == null) == false)
                {
                    if (OnLauncherLog != null) OnLauncherLog(this, new LauncherEventArgs("MINECRAFT", read));

                    // [Server thread/ERROR]: This crash report has been saved to: D:\Example\x.x.x\crash-reports\crash-2000-01-01_00.00.00-(server/client).txt
                    if (read.Contains("[Server thread/ERROR]: This crash report has been saved to"))
                    {
                        string[] line_parts = read.Split(':');

                        string drive = line_parts[2].ToCharArray()[1].ToString();
                        string path = drive + ":\\" + line_parts[3];

                        new frmMinecraftCrashLog(path, ver).Show();
                    }
                }
            }
            if(mcProcess.ExitCode == -1)
            {

            }
        }

        public static void Extract(string zipFileName, string outputDirectory, string excludeCard = "")
        {
            bool exclude = true;
            if (excludeCard == "")
            {
                exclude = false;
            }
            ZipFile zip = ZipFile.Read(zipFileName);
            Directory.CreateDirectory(outputDirectory);
            foreach (ZipEntry e in zip)
            {
                if (exclude)
                {
                    if (!e.FileName.Contains(excludeCard))
                    {
                        e.Extract(outputDirectory, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                else
                {
                    e.Extract(outputDirectory, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }

        private Dictionary<string, string[]> getVersionData(string json)
        {
            string archType = "32";
            if (Environment.Is64BitOperatingSystem)
            {
                archType = "64";
            }
            dynamic version = JsonConvert.DeserializeObject(json);
            string[] libraries = { "" };
            string[] urlLibraries = { "" };
            int l = 0;
            string[] natives = { "" };
            int n = 0;
            foreach (var param in version.libraries)
            {
                bool isNative = false;
                bool addFile = true;
                bool modFile = false;
                if (param.rules != null)
                {
                    foreach (var entry in param.rules)
                    {
                        if (entry.action == "allow")
                        {
                            if (entry.os != null)
                            {
                                if (entry.os.name != "windows")
                                {
                                    addFile = false;
                                }
                            }
                        }
                        else
                        {
                            if (entry.os != null)
                            {
                                if (entry.os.name == "windows")
                                {
                                    addFile = false;
                                }
                            }
                            else
                            {
                                addFile = false;
                            }
                        }
                    }
                }
                if (param.url != null)
                {
                    modFile = true;
                }
                if (addFile)
                {
                    string fileName = param.name;
                    string[] colonSplit = fileName.Split(new char[] { ':' }, 3);
                    string[] folderSplit = colonSplit[0].Split(new char[] { '.' });
                    string compileFolder = "";
                    foreach (string entry in folderSplit)
                    {
                        compileFolder += entry + @"\";
                    }
                    string compileSplit = "";
                    if (param.natives != null)
                    {
                        isNative = true;
                        compileSplit = compileFolder + colonSplit[1] + @"\" + colonSplit[2] + @"\" + colonSplit[1] + "-" + colonSplit[2] + "-" + param.natives.windows + ".jar";
                    }
                    else
                    {
                        compileSplit = compileFolder + colonSplit[1] + @"\" + colonSplit[2] + @"\" + colonSplit[1] + "-" + colonSplit[2] + ".jar";
                    }
                    string compileComplete = compileSplit.Replace("${arch}", archType);
                    if (l > libraries.Length - 1)
                    {
                        Array.Resize(ref libraries, libraries.Length + 1);
                        Array.Resize(ref urlLibraries, libraries.Length + 1);
                    }
                    libraries[l] = compileComplete;
                    if (modFile)
                    {
                        urlLibraries[l] = param.url;
                    }
                    else
                    {
                        urlLibraries[l] = "";
                    }
                    l++;
                    if (isNative)
                    {
                        if (n > natives.Length - 1)
                        {
                            Array.Resize(ref natives, natives.Length + 1);
                        }
                        natives[n] = compileComplete;
                        n++;
                    }
                }
            }
            string tmpAssets = "legacy";
            if (version.assets != null)
            {
                tmpAssets = version.assets;
            }
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>{
{"id" , new string[] { version.id }},
{"time" , new string[] { version.time }},
{"releaseTime" , new string[] { version.releaseTime }},
{"type" , new string[] { version.type }},
{"minecraftArguments" , new string[] { version.minecraftArguments }},
{"mainClass" , new string[] { version.mainClass }},
{"assets" , new string[] { tmpAssets }},
//{"libraries" , new string[] { "net/sf/jopt-simple/jopt-simple/4.5/jopt-simple-4.5.jar" "etc" "etc" }},
{"libraries" , libraries },
{"urlLibraries" , urlLibraries },
//{"natives" , new string[] { "net/sf/jopt-simple/jopt-simple/4.5/jopt-simple-4.5.jar" "etc" "etc" }},
{"natives" , natives }
};
            return dict;
        }

    }
}
