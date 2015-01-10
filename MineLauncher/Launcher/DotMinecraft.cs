using System;
using System.IO;

namespace MineLauncher.Launcher
{
    internal class DotMinecraft
    {

        public static void CreateDotMinecraftHierarchy()
        {
            string basePath = GlobalConfig.AppDataPath + "\\.minecraft";

            CreateDirectoryIfNotExists(basePath);
            CreateDirectoryIfNotExists(basePath + "\\assets");
            CreateDirectoryIfNotExists(basePath + "\\assets\\objects");
            CreateDirectoryIfNotExists(basePath + "\\assets\\indexes");
            CreateDirectoryIfNotExists(basePath + "\\libraries");
            CreateDirectoryIfNotExists(basePath + "\\versions");
            CreateDirectoryIfNotExists(basePath + "\\minelauncher");
            CreateDirectoryIfNotExists(basePath + "\\minelauncher\\logs");
            CreateDirectoryIfNotExists(basePath + "\\minelauncher\\head");
        }

        private static void CreateDirectoryIfNotExists(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

    }
}
