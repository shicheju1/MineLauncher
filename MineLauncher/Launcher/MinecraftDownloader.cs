﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using Newtonsoft.Json;

using MineLauncher.Events;

namespace MineLauncher.Launcher
{

    internal class MinecraftDownloader
    {

        Dictionary<string, string[]> rawVersionData;
        Dictionary<string, string[]> rawAssetsData;

        private List<string[]> _assets = new List<string[]>();
        private List<string[]> _libraries = new List<string[]>();

        public List<string[]> Assets { get { return this._assets; } }

        public List<string[]> Libraries { get { return this._libraries; } }
        
        private string _assetspath = "";
        private string _legacyassetspath = "";
        private string _librariespath = "";
        private string _versionpath = "";
        private string _versionspath = "";

        public delegate void DownloadHandler(object sender, DownloadEventArgs e);
        public event DownloadHandler OnDownload;

        public MinecraftDownloader(string version)
        {
            _assetspath = GlobalConfig.AppDataPath + "\\.minecraft\\assets\\objects";
            _legacyassetspath = GlobalConfig.AppDataPath + "\\.minecraft\\assets\\virtual\\legacy";
            _librariespath = GlobalConfig.AppDataPath + "\\.minecraft\\libraries";
            _versionpath = GlobalConfig.AppDataPath + "\\.minecraft\\versions\\" + version;
            _versionspath = GlobalConfig.AppDataPath + "\\.minecraft\\versions";

            string _version_json = File.ReadAllText(_versionpath + "\\" + version + ".json");
            string _version_assets = "";
            string _version_basever = "";

            rawVersionData = getVersionData(_version_json);
            _version_basever = rawVersionData["assets"][0];

            try
            {
                _version_json = new WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/" + version + "/" + version + ".json");
                rawVersionData = getVersionData(_version_json);
            }
            catch (Exception)
            {
                try
                {
                    rawVersionData = getVersionData(File.ReadAllText(_versionpath + "\\" + version + ".json"));
                }
                catch (Exception)
                {
                    if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Failed to download the version-JSON", 1, 1, "Error"));
                    return;
                }
            }

            try
            {
                _version_assets = new WebClient().DownloadString("https://s3.amazonaws.com/Minecraft.Download/indexes/" + rawVersionData["assets"][0] + ".json");
                rawAssetsData = getAssetsList(_version_assets);
            }
            catch (Exception)
            {
                try
                {
                    rawAssetsData = getAssetsList(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\assets\\indexes\\" + rawVersionData["assets"][0] + ".json"));
                }
                catch (Exception)
                {
                    if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Failed to download the assets-JSON", 1, 1, "Error"));
                    return;
                }
            }

            int modCount = 0;
            foreach (string library in rawVersionData["libraries"])
            {
                if (rawVersionData["urlLibraries"][modCount] == "")
                {
                    _libraries.Add(new string[] { 
                        "https://libraries.minecraft.net/" + library.Replace(@"\", "/"), 
                        Path.Combine(_librariespath, library) 
                    });
                }
                else
                {
                    _libraries.Add(new string[] { 
                        rawVersionData["urlLibraries"][modCount] + library.Replace(@"\", "/"),
                        Path.Combine(_librariespath, library)
                    });
                }

                modCount++;
            }

            foreach (KeyValuePair<string, string[]> asset in rawAssetsData)
            {
                if (rawVersionData["assets"][0] == "legacy")
                {
                    _assets.Add(new string[] { 
                        "http://resources.download.minecraft.net/" + asset.Value[0].Truncate(2) + "/" + asset.Value[0], 
                        Path.Combine(_legacyassetspath, asset.Value[0].Truncate(2) + @"\" + asset.Value[0])
                    });
                }
                else
                {
                    _assets.Add(new string[] { 
                        "http://resources.download.minecraft.net/" + asset.Value[0].Truncate(2) + "/" + asset.Value[0], 
                        Path.Combine(_assetspath, asset.Value[0].Truncate(2) + @"\" + asset.Value[0])
                    });
                }
            }

            if (!File.Exists(_versionpath + "\\" + version + ".jar"))
            {
                _libraries.Add(new string[] { 
                    "http://s3.amazonaws.com/Minecraft.Download/versions/" + version + "/" + version + ".jar", 
                    Path.Combine(_versionpath, version + ".jar")
                });
            }

            if (!Directory.Exists(_versionpath))
                Directory.CreateDirectory(_versionpath);
            if (!Directory.Exists(_librariespath))
                Directory.CreateDirectory(_librariespath);
            if (!Directory.Exists(_assetspath))
                Directory.CreateDirectory(_assetspath);
            if (!Directory.Exists(_versionpath))
                Directory.CreateDirectory(_versionpath);

            if (!Directory.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\assets\\indexes"))
                Directory.CreateDirectory(GlobalConfig.AppDataPath + "\\.minecraft\\assets\\indexes");

            File.WriteAllText(_versionpath + "\\" + version + ".json", _version_json);
            File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\assets\\indexes\\" + rawVersionData["assets"][0] + ".json", _version_assets);
        }

        public void StartDownload()
        {
            int dnld_max = _libraries.Count + _assets.Count + rawVersionData["natives"].Length;
            int dnld_curr = 0;

            WebClient downloader = new WebClient();

            foreach (string[] item in _libraries)
            {
                string url = item[0];
                string path = item[1];

                new DirectoryInfo(Path.GetDirectoryName(path)).CreateDirectoryStructure();
                if(!File.Exists(path))
                {
                    if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Downloading " + Path.GetFileNameWithoutExtension(path), dnld_max, dnld_curr, Path.GetFileNameWithoutExtension(path)));
                    if(downloader.RemoteExists(url))
                    {
                        try
                        {
                            Console.WriteLine("[" + DateTime.Now.ToString() + "][DOWNLOADER] Downloading library " + Path.GetFileNameWithoutExtension(path) + "...");
                            downloader.DownloadFile(url, path);
                        }
                        catch (Exception)
                        {
                            if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Downloading of " + Path.GetFileNameWithoutExtension(path) + " failed", dnld_max, dnld_curr, Path.GetFileNameWithoutExtension(path)));
                        }
                    }
                    else
                    {
                        if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Downloading of " + Path.GetFileNameWithoutExtension(path) + " failed", dnld_max, dnld_curr, Path.GetFileNameWithoutExtension(path)));
                    }
                }
                else
                    Console.WriteLine("[" + DateTime.Now.ToString() + "][DOWNLOADER] Library " + Path.GetFileNameWithoutExtension(path) + " exists.");

                dnld_curr++;
            }

            foreach (string entry in rawVersionData["natives"])
            {
                if (!String.IsNullOrEmpty(entry) && !String.IsNullOrWhiteSpace(entry))
                {
                    Console.WriteLine("[" + DateTime.Now.ToString() + "][DOWNLOADER] Extracing native " + Path.GetFileNameWithoutExtension(entry) + "...");
                    Extract(_librariespath + "\\" + entry, _versionspath + "\\" + rawVersionData["id"][0] + "\\" + rawVersionData["id"][0] + "-natives-AL74", "META-INF");
                }
                dnld_curr++;
            }

            foreach (string[] item in _assets)
            {
                string url = item[0];
                string path = item[1];

                new FileInfo(path).Directory.CreateDirectoryStructure();
                if (!File.Exists(path))
                {
                    if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Downloading " + Path.GetFileNameWithoutExtension(path), dnld_max, dnld_curr, Path.GetFileNameWithoutExtension(path)));
                    if (downloader.RemoteExists(url))
                    {
                        try
                        {
                            Console.WriteLine("[" + DateTime.Now.ToString() + "][DOWNLOADER] Downloading asset " + Path.GetFileNameWithoutExtension(path) + "...");
                            downloader.DownloadFile(url, path);
                        }
                        catch (Exception)
                        {
                            if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Downloading of " + Path.GetFileNameWithoutExtension(path) + " failed", dnld_max, dnld_curr, Path.GetFileNameWithoutExtension(path)));
                        }
                    }
                    else
                    {
                        if (OnDownload != null) OnDownload(this, new DownloadEventArgs("Downloading of " + Path.GetFileNameWithoutExtension(path) + " failed", dnld_max, dnld_curr, Path.GetFileNameWithoutExtension(path)));
                    }
                }
                else
                    Console.WriteLine("[" + DateTime.Now.ToString() + "][DOWNLOADER] Asset " + Path.GetFileNameWithoutExtension(path) + " exists.");

                dnld_curr++;
            }
        }

        public static void Extract(string zipFileName, string outputDirectory, string excludeCard = "")
        {
            bool exclude = true;
            if (excludeCard == "")
            {
                exclude = false;
            }
            Ionic.Zip.ZipFile zip = Ionic.Zip.ZipFile.Read(zipFileName);
            Directory.CreateDirectory(outputDirectory);
            foreach (Ionic.Zip.ZipEntry e in zip)
            {
                if (exclude)
                {
                    if (!e.FileName.Contains(excludeCard))
                    {
                        try
                        {
                            e.Extract(outputDirectory, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                        }
                        catch (IOException) { }
                        catch (UnauthorizedAccessException) { }
                    }
                }
                else
                {
                    try
                    {
                        e.Extract(outputDirectory, Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
                    }
                    catch (IOException) { }
                    catch (UnauthorizedAccessException) { }
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

        private Dictionary<string, string[]> getAssetsList(string json)
        {
            dynamic assets = JsonConvert.DeserializeObject(json);
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>
            {
                //{"objectFileLocation", new string[] { "hash", "size" }},
            };
            var values = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(Convert.ToString(assets.objects));
            foreach (KeyValuePair<string, dynamic> entry in values)
            {
                dict.Add(entry.Key, new string[] { entry.Value.hash, entry.Value.size });
            }
            return dict;
        }

    }

}
