using System;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

using MineLauncher.UI.Forms;
using MineLauncher.Win32Api;

namespace MineLauncher
{
    internal static class Program
    {

        public static ExceptionBase.ExceptionBase ExceptionTracker;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string architcture = Environment.Is64BitOperatingSystem ? "64" : "86";

            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                if(args.Name.StartsWith("ExceptionBase"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.ExceptionBase);
                }
                /* else if(args.Name.StartsWith("nUpdate"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.nUpdate);
                } */
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
                else if (args.Name.StartsWith("Microsoft.WindowsAPICodePack") && !args.Name.StartsWith("Microsoft.WindowsAPICodePack.Shell"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.Microsoft_WindowsAPICodePack);
                }
                else if (args.Name.StartsWith("Microsoft.WindowsAPICodePack.Shell"))
                {
                    return Assembly.Load(MineLauncher.Properties.Resources.Microsoft_WindowsAPICodePack_Shell);
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
