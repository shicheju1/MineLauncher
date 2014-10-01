using System;
using System.IO;

namespace MineLauncher.Launcher
{
    public class DotMinecraft
    {

        public static void CreateDotMinecraftHierarchy()
        {
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft";

            CreateDirectoryIfNotExists(basePath);
            CreateDirectoryIfNotExists(basePath + "\\assets");
            CreateDirectoryIfNotExists(basePath + "\\assets\\objects");
            CreateDirectoryIfNotExists(basePath + "\\assets\\indexes");
            CreateDirectoryIfNotExists(basePath + "\\libraries");
            CreateDirectoryIfNotExists(basePath + "\\versions");
            CreateDirectoryIfNotExists(basePath + "\\minelauncher");
            CreateDirectoryIfNotExists(basePath + "\\minelauncher\\logs");
        }

        private static void CreateDirectoryIfNotExists(string path)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        }

    }
}
