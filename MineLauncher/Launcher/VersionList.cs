using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

using Newtonsoft.Json;

namespace MineLauncher.Launcher
{

    public enum VersionListType
    {
        Release,
        Snapshot,
        Beta,
        Alpha,
        Custom,
        All
    }

    public class VersionList
    {

        public delegate void VersionFetchHandler(object sender, string version);
        public event VersionFetchHandler OnVersionFetching;
        public event VersionFetchHandler OnVersionFetched;
        
        public List<string> GetVersionList(VersionListType types)
        {
            List<string> returnList = new List<string>();
            Dictionary<string, string[]> rawList = getVersionList(new WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/versions.json"));

            foreach(KeyValuePair<string, string[]> rawEntry in rawList)
            {
                if (types == VersionListType.Alpha && rawEntry.Value[2] == "old_alpha")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if (types == VersionListType.Beta && rawEntry.Value[2] == "old_beta")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if (types == VersionListType.Release && rawEntry.Value[2] == "release")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if (types == VersionListType.Snapshot && rawEntry.Value[2] == "snapshot")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if(types == VersionListType.All)
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
            }

            if (types == VersionListType.Custom || types == VersionListType.All)
            {
                Dictionary<string, string[]> _rawList = new Dictionary<string, string[]>();

                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\versions"))
                {
                    foreach (DirectoryInfo versions in new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\versions").GetDirectories())
                    {
                        if (!rawList.ContainsKey(versions.Name))
                        {
                            dynamic versionJson = JsonConvert.DeserializeObject(File.ReadAllText(versions.FullName + "\\" + versions.Name + ".json"));
                            string keyString = versionJson.id;
                            string[] arrString = { versionJson.time, versionJson.releaseTime, versionJson.type };
                            rawList.Add(keyString, arrString);
                        }
                    }

                    foreach (KeyValuePair<string, string[]> rawEntry in _rawList)
                    {
                        if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                        returnList.Add(rawEntry.Key);
                        if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                    }
                }
            }

            return returnList;
        }

        public List<string> GetVersionList(Dictionary<string, string[]> rawList, VersionListType types)
        {
            List<string> returnList = new List<string>();

            foreach (KeyValuePair<string, string[]> rawEntry in rawList)
            {
                if (types == VersionListType.Alpha && rawEntry.Value[2] == "old_alpha")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if (types == VersionListType.Beta && rawEntry.Value[2] == "old_beta")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if (types == VersionListType.Release && rawEntry.Value[2] == "release")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if (types == VersionListType.Snapshot && rawEntry.Value[2] == "snapshot")
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
                else if (types == VersionListType.All)
                {
                    if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                    returnList.Add(rawEntry.Key);
                    if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                }
            }

            if (types == VersionListType.Custom || types == VersionListType.All)
            {
                Dictionary<string, string[]> _rawList = new Dictionary<string, string[]>();

                if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\versions"))
                {
                    foreach (DirectoryInfo versions in new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\versions").GetDirectories())
                    {
                        if (!rawList.ContainsKey(versions.Name) && File.Exists(versions.FullName + "\\" + versions.Name + ".json"))
                        {
                            dynamic versionJson = JsonConvert.DeserializeObject(File.ReadAllText(versions.FullName + "\\" + versions.Name + ".json"));
                            string keyString = versionJson.id;
                            string[] arrString = { versionJson.time, versionJson.releaseTime, versionJson.type };
                            _rawList.Add(keyString, arrString);
                        }
                    }

                    foreach (KeyValuePair<string, string[]> rawEntry in _rawList)
                    {
                        if (OnVersionFetching != null) OnVersionFetching(this, rawEntry.Key);
                        returnList.Add(rawEntry.Key);
                        if (OnVersionFetched != null) OnVersionFetched(this, rawEntry.Key);
                    }
                }
            }

            return returnList;
        }
        
        public static Dictionary<string, string[]> getVersionList(string json)
        {
            dynamic version = JsonConvert.DeserializeObject(json);
            Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

            foreach (dynamic entry in version.versions)
            {
                string keyString = entry.id;
                string[] arrString = { entry.time, entry.releaseTime, entry.type };
                dict.Add(keyString, arrString);
            }
            return dict;
        }

    }
}
