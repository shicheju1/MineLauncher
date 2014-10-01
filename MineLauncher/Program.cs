﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MineLauncher
{
    static class Program
    {

        public static ExceptionBase.ExceptionBase ExceptionTracker;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                if(args.Name.StartsWith("ExceptionBase"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.ExceptionBase);
                }
                else if (args.Name.StartsWith("Newtonsoft.Json"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.Newtonsoft_Json);
                }
                else if (args.Name.StartsWith("Ionic.Zip"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.Ionic_Zip);
                }
                else if (args.Name.StartsWith("MetroFramework") && !args.Name.StartsWith("MetroFramework.Design") && !args.Name.StartsWith("MetroFramework.Fonts"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.MetroFramework);
                }
                else if (args.Name.StartsWith("MetroFramework.Design"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.MetroFramework_Design);
                }
                else if (args.Name.StartsWith("MetroFramework.Fonts"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.MetroFramework_Fonts);
                }
                return null;
            };

            MainCore();
        }

        static void MainCore()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ExceptionTracker = new ExceptionBase.ExceptionBase("http://exception.lukasberger.at/api/addException/", 3, Application.ProductVersion);

            AppDomain.CurrentDomain.UnhandledException += ((object sender, UnhandledExceptionEventArgs e) =>
            {
                ExceptionTracker.Track((Exception)e.ExceptionObject, false, false);
            });

            Application.ThreadException += ((object sender, System.Threading.ThreadExceptionEventArgs e) =>
            {
                ExceptionTracker.Track(e.Exception, false, false);
            });

            Application.Run(new frmLauncher());
        }
        
    }
}