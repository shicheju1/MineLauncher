using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using MetroFramework.Forms;

using MineLauncher;
using MineLauncher.Events;
using MineLauncher.Launcher;
using MineLauncher.UI.Controls;
using MineLauncher.Win32Api;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//using nUpdate.Internal;

using Microsoft.WindowsAPICodePack.Taskbar;

namespace MineLauncher.UI.Forms
{
    internal partial class frmLauncher : MetroForm
    {

        string uitheme = "";
        int head_type = 0;
        bool base_offline_mode = false;

        /* UpdateManager updater;
        UpdaterUI updaterui; */
        bool updater_include_alpha = false;
        bool updater_include_beta = false;

        Random rand = new Random();
        MinecraftSession session = null;
        KeyValuePair<string, Dictionary<string, object>> currentProfile = new KeyValuePair<string, Dictionary<string, object>>();
        Dictionary<string, string[]> rawVersionList = new Dictionary<string, string[]>();

        TaskbarManager taskbar;

        frmStarting starting;
        
        public frmLauncher()
        {
            string architcture = Environment.Is64BitOperatingSystem ? "64" : "86";
            string program_files = Environment.Is64BitOperatingSystem ? Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) : Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

            Console.WriteLine("STARTING MINELAUNCHER...");
            Console.WriteLine("APPDATA: " + GlobalConfig.AppDataPath);
            Console.WriteLine("APPDATA EXISTS: " + Directory.Exists(GlobalConfig.AppDataPath));
            Console.WriteLine("JVMPATH: " + GlobalConfig.GetJavaPath(program_files + "\\Java\\jre7\\bin\\javaw.exe"));
            Console.WriteLine("JVMPATH EXISTS: " + File.Exists(GlobalConfig.GetJavaPath(program_files + "\\Java\\jre7\\bin\\javaw.exe")));
            Console.WriteLine("VERSION: " + Application.ProductVersion);
            Console.WriteLine("CURRENT USER: " + Environment.UserName);
            Console.WriteLine("CURRENT TIME: " + DateTime.Now.ToString());
            Console.WriteLine("PROPS: app.prop" + architcture);
            Console.WriteLine("INITIALIZING MINELAUNCHER...");
            
            DotMinecraft.CreateDotMinecraftHierarchy();

            InitializeComponent();

            string[] ver = Application.ProductVersion.Split('.');
            if (ver[3] == "1")
            {
                this.Text = "MineLauncher " + ver[0] + "." + ver[1] + "." + ver[2] + " dev" + ver[3];
                NativeMethods.AllocConsole();
            }
            else if (ver[3] == "2")
            {
                this.Text = "MineLauncher " + ver[0] + "." + ver[1] + "." + ver[2] + " alpha" + ver[3];
            }
            else if (ver[3] == "3")
            {
                this.Text = "MineLauncher " + ver[0] + "." + ver[1] + "." + ver[2] + " beta" + ver[3];
            }
            else            
            {
                this.Text = "MineLauncher " + ver[0] + "." + ver[1] + "." + ver[2];
            }

            if (File.Exists(Directory.GetCurrentDirectory() + "\\app.prop" + architcture))
            {
                if (File.ReadAllLines(Directory.GetCurrentDirectory() + "\\app.prop" + architcture)[2] == "no-setup" && !File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json"))
                {
                    Dictionary<string, object> setup = new Dictionary<string, object>();
                    Dictionary<string, object> setup_updater = new Dictionary<string, object>();
                    Dictionary<string, object> setup_ingame = new Dictionary<string, object>();

                    setup.Add("baseofflinemode", true);
                    setup.Add("theme", "dark");

                    setup_updater.Add("alpha", false);
                    setup_updater.Add("beta", false);

                    setup_ingame.Add("randomicon", true);
                    setup_ingame.Add("changeiconrandom", true);

                    setup.Add("updater", setup_updater);
                    setup.Add("ingame", setup_ingame);

                    File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json", JsonConvert.SerializeObject(setup));
                }
            }

            if (!File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json"))
            {
                this.Enabled = false;
                new frmSetup().ShowDialog();
            }
            else
            {
                dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json"));

                try
                {                    
                    uitheme = (string)setup.theme;
                    head_type = (int)setup.head;
                    updater_include_alpha = (bool)setup.updater.alpha;
                    updater_include_beta = (bool)setup.updater.beta;
                    base_offline_mode = (bool)setup.baseofflinemode;
                
                    cbSettings_Themes.SelectedItem = uitheme;

                    cbSettings_Updater_Including_Alpha.Checked = updater_include_alpha;
                    cbSettings_Updater_Including_Beta.Checked = updater_include_beta;
                }
                catch (Exception)
                {
                    Newtonsoft.Json.Linq.JObject setup_main_jtype = (Newtonsoft.Json.Linq.JObject)(setup);

                    Dictionary<string, object> setup_main = setup_main_jtype.ToObject<Dictionary<string, object>>();

                    if (!setup_main.ContainsKey("theme"))
                        setup_main.Add("theme", "dark");

                    if (!setup_main.ContainsKey("head"))
                        setup_main.Add("head", 1);

                    if (!setup_main.ContainsKey("baseofflinemode"))
                        setup_main.Add("baseofflinemode", true);

                    try
                    {
                        Newtonsoft.Json.Linq.JObject updater_jtype = (Newtonsoft.Json.Linq.JObject)(setup.updater);
                        Dictionary<string, object> updater = updater_jtype.ToObject<Dictionary<string, object>>();

                        if (!updater.ContainsKey("alpha"))
                            updater.Add("alpha", false);

                        if (!updater.ContainsKey("beta"))
                            updater.Add("beta", false);

                        if(!setup_main.ContainsKey("updater"))
                            setup_main.Add("updater", updater);
                        else
                        {
                            setup_main.Remove("updater");
                            setup_main.Add("updater", updater);
                        }
                    }
                    catch (Exception)
                    {
                        Dictionary<string, object> updater = new Dictionary<string, object>();
                        updater.Add("alpha", false);
                        updater.Add("beta", false);

                        if(!setup_main.ContainsKey("updater"))
                            setup_main.Add("updater", updater);
                        else
                        {
                            setup_main.Remove("updater");
                            setup_main.Add("updater", updater);
                        }
                    }

                    try
                    {
                        Newtonsoft.Json.Linq.JObject ingame_jtype = (Newtonsoft.Json.Linq.JObject)(setup.ingame);
                        Dictionary<string, object> ingame = ingame_jtype.ToObject<Dictionary<string, object>>();

                        if (!ingame.ContainsKey("randomicon"))
                            ingame.Add("randomicon", true);

                        if (!ingame.ContainsKey("changeiconrandom"))
                            ingame.Add("changeiconrandom", true);

                        if(!setup_main.ContainsKey("ingame"))
                            setup_main.Add("ingame", ingame);
                        else
                        {
                            setup_main.Remove("ingame");
                            setup_main.Add("ingame", ingame);
                        }
                    }
                    catch (Exception)
                    {
                        Dictionary<string, object> ingame = new Dictionary<string, object>();
                        ingame.Add("randomicon", true);
                        ingame.Add("changeiconrandom", true);
                        
                        if (!setup_main.ContainsKey("ingame"))
                            setup_main.Add("ingame", ingame);
                        else
                        {
                            setup_main.Remove("ingame");
                            setup_main.Add("ingame", ingame);
                        }
                    }
                }
            }

            this.Location = new Point(-50000, -50000);
            this.ShowInTaskbar = false;

            starting = new frmStarting();
            starting.Show();

            new Thread(() =>
            {       
                // nUpdate doesn't work yet

                /* this.SafeInvoke(new Action(() => AddLogEntry("[UPDATER] Searching for updates. This can take a while...")));
                updater = new UpdateManager(new Uri("http://update.lukasberger.at/minelauncher/updates.json"), MineLauncher.Properties.Resources.UpdaterPublicKey, new UpdateVersion(Application.ProductVersion));
                
                updater.IncludeAlpha = updater_include_alpha;
                updater.IncludeBeta = updater_include_beta;
                updater.UseHiddenSearch = true;

                updater.SearchForUpdates();

                if(updater.UpdatesFound)
                {
                    this.SafeInvoke(new Action(() => AddLogEntry("[UPDATER] Updates found, new Version is " + updater.UpdateVersion.ToString())));
                    //this.SafeInvoke(new Action(() => AddLogEntry("[UPDATER] Updates will be installed soon...")));
                    this.SafeInvoke(new Action(() => AddLogEntry("[UPDATER] Sorry, but the installer can't install updates yet")));

                    //updater.InstallPackage();
                }
                else
                {
                    if(nUpdate.Core.ConnectionChecker.IsConnectionAvailable())
                    {
                        this.SafeInvoke(new Action(() => AddLogEntry("[UPDATER] No updates found")));
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => AddLogEntry("[UPDATER] You must have an internet connection to check for updates")));
                    }
                } */

                MEMORYSTATUSEX memory = new MEMORYSTATUSEX();
                NativeMethods.GlobalMemoryStatusEx(memory);
                                
                ChangeFormTheme(this);           

                ulong availMem = memory.ullAvailPhys;
                string memStat = "Fine";

                availMem = availMem / 1024 / 1024 / 1024;

                if (availMem < 1)
                {
                    memStat = "Meh...";
                }
                else if (availMem < 2)
                {
                    memStat = "More is recommended";
                }
                else if (availMem < 4)
                {
                    memStat = "For playing with the standard-textures it is enough";
                }
                else if (availMem < 6)
                {
                    memStat = "Enough, maybe 128x-Textures";
                }
                else if (availMem < 8)
                {
                    memStat = "Fine, but I won't use 512x-Textures";
                }
                                
                this.SafeInvoke(new Action(() => AddLogEntry("[STARTUP] Starting MineLauncher \"Crafter\" Version " + Application.ProductVersion)));
                this.SafeInvoke(new Action(() => AddLogEntry("[STARTUP] System: " + Environment.OSVersion.GetOSFullName() + ", " + Environment.OSVersion.ToString())));
                this.SafeInvoke(new Action(() => AddLogEntry("[STARTUP] Memory: " + Math.Round((double)memory.ullTotalPhys / 1024 / 1024, 2) + "MB")));
                this.SafeInvoke(new Action(() => AddLogEntry("[STARTUP] Available Memory: " + Math.Round((double)memory.ullAvailPhys / 1024 / 1024, 2) + "MB - " + memStat)));
                
                if (TaskbarManager.IsPlatformSupported) taskbar = TaskbarManager.Instance;

                this.SafeInvoke(new Action(() => lblAbout.Text = String.Format(lblAbout.Text,
                    Assembly.GetExecutingAssembly().GetName().Version.Major,
                    Assembly.GetExecutingAssembly().GetName().Version.Minor,
                    Assembly.GetExecutingAssembly().GetName().Version.Build,
                    Assembly.GetExecutingAssembly().GetName().Version.Revision)));

                this.SafeInvoke(new Action(() => tcMain.SelectedIndex = 0));

                List<System.Drawing.Icon> icons = new List<System.Drawing.Icon>();
                icons.Add(MineLauncher.Properties.Resources.Creeper_Blue);
                icons.Add(MineLauncher.Properties.Resources.Creeper_Green);
                icons.Add(MineLauncher.Properties.Resources.Creeper_Orange);
                icons.Add(MineLauncher.Properties.Resources.Creeper_Red);
                icons.Add(MineLauncher.Properties.Resources.Creeper_Standard);
                icons.Add(MineLauncher.Properties.Resources.Creeper_Violet);
                icons.Add(MineLauncher.Properties.Resources.Creeper_Yellow);

                try
                {
                    this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Trying to login with saved session")));
                    session = MinecraftSession.LoginWithSavedSession();
                    if (session.LoggedIn)
                    {
                        this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Logged in as " + session.PlayerName)));
                        this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Session: " + session.Session)));
                        new Thread(() =>
                        {
                            try
                            {
                                string type = "avatar";

                                if (head_type == 1)
                                    type = "avatar";
                                else if (head_type == 2)
                                    type = "helm";
                                else if (head_type == 3)
                                    type = "cube";

                                new System.Net.WebClient().DownloadFile("https://minotar.net/" + type + "/" + session.PlayerName + "/64.png", GlobalConfig.AppDataPath +
                                    "\\.minecraft\\minelauncher\\head\\" + session.PlayerName + ".png");
                                Icon headIcon = Icon.FromHandle(new Bitmap(Image.FromFile(GlobalConfig.AppDataPath +
                                    "\\.minecraft\\minelauncher\\head\\" + session.PlayerName + ".png"), new Size(64, 64)).GetHicon());
                                this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Got player's head")));

                                this.BeginInvoke(new Action(() =>
                                {
                                    pbFastInfo_Avatar.Image = headIcon.ToBitmap();
                                }));
                            }
                            catch (Exception)
                            {
                                this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Error while getting player's head")));
                            }
                        }).Start();
                        this.BeginInvoke(new Action(() =>
                        {
                            tbFastLogin_Password.Text = "";
                            tbFastLogin_Username.Text = "";
                            lblFastInfo_Welcome.Text = String.Format(lblFastInfo_Welcome.Text, session.PlayerName);
                            this.pnlFastLogin.Enabled = false;
                            this.pnlFastLogin.Visible = false;
                            pnlFastInfo.Visible = true;
                        }));
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Couldn't login with saved session")));
                        this.BeginInvoke(new Action(() =>
                        {
                            this.pnlFastLogin.Enabled = true;
                        }));
                    }

                    try
                    {
                        string version_list_json = new System.Net.WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/versions.json");
                        rawVersionList = VersionList.getVersionList(version_list_json);
                        List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.All);

                        foreach (string version in versions)
                        {
                            this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                        }
	                }
                    catch (Exception) { }

                    if (File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"))
                    {
                        dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));
                        Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);

                        Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
                        foreach (KeyValuePair<string, Dictionary<string, object>> profile in profiles)
                        {
                            this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add(profile.Key)));
                            this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Add(profile.Key)));
                        }
                    }
                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("")));
                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
                }
                catch (Exception ex)
                {
                    Program.ExceptionTracker.Track(ex, false, false);
                }

                this.SafeInvoke(new Action(() =>
                {
                    this.StartPosition = FormStartPosition.CenterScreen;
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                    this.ShowInTaskbar = true;

                    this.Focus();
                    starting.CloseStartingDialog();
                    starting = null;

                    pbLog.BackColor = Color.DodgerBlue;
                }));

                this.SafeInvoke(new Action(() => this.Icon = icons[rand.Next(0, 6)]));

                this.SafeInvoke(new Action(() => this.rtbLog.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold)));
                this.SafeInvoke(new Action(() => this.rtbChat.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold)));
                this.SafeInvoke(new Action(() => this.rtbAbout_Licenses.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold)));
            }).Start();
        }
        
        private void frmLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Prevent errors like ObjectDisposedException and so on
            Environment.Exit(0);
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void AddLogEntry(string entry, Process clientProcess = null)
        {
            string _e = "[" + DateTime.Now.ToString() + "] " + entry;

            DateTime now = DateTime.Now;
            string date = String.Format("{0:yyyy-MM-dd}", now);         

            if (_e.Contains("[Client thread/INFO]: [CHAT]"))
            {
                string _chat = _e.Split(new string[] { "[Client thread/INFO]: [CHAT]" }, StringSplitOptions.None)[1];                
                string __e = "[" + now.ToString() + "] " + _chat + "\n";

                bool lastCharWasColorChar = false;
                foreach (char c in __e)
                {
                    if (c == '§' && !lastCharWasColorChar)
                        lastCharWasColorChar = true;
                    else if (lastCharWasColorChar)
                    {
                        switch (c)
                        {
                            // ## ## ## ## ## ## ## ##
                            // COLORS - CODES (0 - 9)
                            // ## ## ## ## ## ## ## ##
                            case '0':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#000000");
                                return;
                            case '1':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#0000AA");
                                return;
                            case '2':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#00AA00");
                                return;
                            case '3':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#00AAAA");
                                return;
                            case '4':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#AA0000");
                                return;
                            case '5':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#AA00AA");
                                return;
                            case '6':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#FFAA00");
                                return;
                            case '7':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#AAAAAA");
                                return;
                            case '8':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#555555");
                                return;
                            case '9':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#5555FF");
                                return;

                            // ## ## ## ## ## ## ## ##
                            // COLORS - CODES (a - f)
                            // ## ## ## ## ## ## ## ##
                            case 'a':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#55FF55");
                                return;
                            case 'b':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#55FFFF");
                                return;
                            case 'c':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#FF5555");
                                return;
                            case 'd':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#FF55FF");
                                return;
                            case 'e':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#FFFF55");
                                return;
                            case 'f':
                                rtbChat.SelectionColor = ColorTranslator.FromHtml("#FFFFFF");
                                return;

                            // ## ## ## ## ## ## ## ##
                            // FORMAT - CODES (0 - 9)
                            // ## ## ## ## ## ## ## ##
                            case 'l':
                                rtbChat.SelectionFont = new Font(rtbChat.SelectionFont, FontStyle.Bold);
                                return;
                            case 'm':
                                rtbChat.SelectionFont = new Font(rtbChat.SelectionFont, FontStyle.Strikeout);
                                return;
                            case 'n':
                                rtbChat.SelectionFont = new Font(rtbChat.SelectionFont, FontStyle.Underline);
                                return;
                            case 'o':
                                rtbChat.SelectionFont = new Font(rtbChat.SelectionFont, FontStyle.Italic);
                                return;

                            // ## ## ## ## ## ## ##
                            // RESET - CODE (0 - 9)
                            // ## ## ## ## ## ## ##
                            case 'r':
                                rtbChat.SelectionFont = new Font(rtbChat.SelectionFont, FontStyle.Regular);
                                rtbChat.SelectionColor = rtbChat.ForeColor;
                                return;
                        }
                        lastCharWasColorChar = false;
                    }
                    else
                        rtbChat.AppendText(c.ToString());
               }

               rtbChat.ScrollToCaret();
            }
            else
            {
                rtbLog.AppendText(_e + "\n");
                rtbLog.ScrollToCaret();
            }   

            string filename = GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\logs\\" + date + ".log";
            File.AppendAllText(filename, _e + "\n");

            Console.WriteLine(_e);
        }
        
        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        #region About
        
        private void linkAbout_GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Lukas0610/MineLauncher/");
        }


        private void lblAbout_MetroFramework_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/viperneo/winforms-modernui/");
        }

        private void lblAbout_ExceptionBase_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://exceptionbase.net/");
        }

        private void lblAbout_NewtonsoftJson_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://james.newtonking.com/json");
        }

        private void lblAbout_IonicZip_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dotnetzip.codeplex.com/");
        }

        private void lblAbout_nUpdate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://nupdate.net/");
        }

        private void lblAbout_WindowsApiCodePack_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nuget.org/packages/Windows7APICodePack/");
        }
        
        private void lblAbout_CraftNet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SirCmpwn");
        }

        #endregion

        #region Theme

        public void ChangeFormTheme(MetroForm form)
        {
            this.SafeInvoke(new Action(() => form.Theme = GetMetroThemeFromConfig()));
            this.SafeInvoke(new Action(() => form.Refresh()));

            foreach (Control ctrl in ((Control)form).Controls)
            {
                if (ctrl is IMetroControl)
                {
                    this.SafeInvoke(new Action(() => ((IMetroControl)ctrl).Theme = GetMetroThemeFromConfig()));
                }
                else if (ctrl is Control)
                {
                    if (GetMetroThemeFromConfig() == MetroThemeStyle.Dark)
                    {
                        this.SafeInvoke(new Action(() => ((Control)ctrl).BackColor = Color.FromArgb(17, 17, 17)));
                        this.SafeInvoke(new Action(() => ((Control)ctrl).ForeColor = Color.FromArgb(170, 170, 170)));
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => ((Control)ctrl).BackColor = Color.FromArgb(255, 255, 255)));
                        this.SafeInvoke(new Action(() => ((Control)ctrl).ForeColor = Color.FromArgb(0, 0, 0)));
                    }
                }

                this.SafeInvoke(new Action(() => ctrl.Refresh()));
                ChangeControlTheme(ctrl);
            }
        }

        private void ChangeControlTheme(Control ctrl)
        {
            if (ctrl is IMetroControl)
            {
                this.SafeInvoke(new Action(() => ((IMetroControl)ctrl).Theme = GetMetroThemeFromConfig()));
            }
            else
            {
                if (GetMetroThemeFromConfig() == MetroThemeStyle.Dark)
                {
                    this.SafeInvoke(new Action(() => ((Control)ctrl).BackColor = Color.FromArgb(17, 17, 17)));
                    this.SafeInvoke(new Action(() => ((Control)ctrl).ForeColor = Color.FromArgb(170, 170, 170)));
                }
                else
                {
                    this.SafeInvoke(new Action(() => ((Control)ctrl).BackColor = Color.FromArgb(255, 255, 255)));
                    this.SafeInvoke(new Action(() => ((Control)ctrl).ForeColor = Color.FromArgb(0, 0, 0)));
                }
            }
            this.SafeInvoke(new Action(() => ctrl.Refresh()));

            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is IMetroControl)
                {
                    this.SafeInvoke(new Action(() => ((IMetroControl)subctrl).Theme = GetMetroThemeFromConfig()));
                }
                else if (subctrl is Control)
                {
                    if (GetMetroThemeFromConfig() == MetroThemeStyle.Dark)
                    {
                        this.SafeInvoke(new Action(() => ((Control)subctrl).BackColor = Color.FromArgb(17, 17, 17)));
                        this.SafeInvoke(new Action(() => ((Control)subctrl).ForeColor = Color.FromArgb(170, 170, 170)));
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => ((Control)subctrl).BackColor = Color.FromArgb(255, 255, 255)));
                        this.SafeInvoke(new Action(() => ((Control)subctrl).ForeColor = Color.FromArgb(0, 0, 0)));
                    }
                }
                this.SafeInvoke(new Action(() => subctrl.Refresh()));
                ChangeControlTheme(subctrl);
            }
        }

        private MetroThemeStyle GetMetroThemeFromConfig()
        {
            if (uitheme == "Light")
            {
                return MetroThemeStyle.Light;
            }
            else
            {
                return MetroThemeStyle.Dark;
            }
        }

        #endregion

        #region Profile Editor

        private void tbProfiles_Edit_Name_TextChanged(object sender, EventArgs e)
        {
            if (tbProfiles_Edit_Directory.Text.StartsWith("C:\\Minecraft\\"))
            {
                tbProfiles_Edit_Directory.Text = "C:\\Minecraft\\" + tbProfiles_Edit_Name.Text;
            }   
        }
        
        private void btnProfile_Edit_Delete_Click(object sender, EventArgs e)
        {
            new Thread(() => 
            {
                dynamic _profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));
                Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(_profilejson);

                Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
            
                profiles.Remove(tbProfiles_Edit_Name.Text);

                string json = JsonConvert.SerializeObject(profiles);
                File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json", json);

                this.SafeInvoke(new Action(() =>
                {
                    cbProfiles_Select.Items.Clear();
                    cbFastControl_SelectProfile.Items.Clear();
                    foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
                    {
                        cbProfiles_Select.Items.Add(newProfile.Key);
                        cbFastControl_SelectProfile.Items.Add(newProfile.Key);
                    }
                    cbProfiles_Select.Items.Add("");
                    cbProfiles_Select.Items.Add("Create new profile");
                }));
            }).Start();
        }
        
        private void btnProfile_Edit_Save_Click(object sender, EventArgs e)
        {
            object edit_version = cbProfiles_Edit_Version.Items[cbProfiles_Edit_Version.SelectedIndex];
            string edit_directory = tbProfiles_Edit_Directory.Text;
            string edit_jvm_path = tbProfiles_Edit_JVM_Path.Text;
            string edit_jvm_args = tbProfiles_Edit_JVM_Args.Text;
            bool edit_offline = toggleProfiles_Edit_Offline.Checked;
            string edit_offline_playername = tbProfiles_Edit_Offline_PlayerName.Text;
            string edit_name = tbProfiles_Edit_Name.Text;

            new Thread(() =>
            {
                if (tbProfiles_Edit_Name.Text == "")
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) profile name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                if (tbProfiles_Edit_Directory.Text == "")
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                if (tbProfiles_Edit_JVM_Path.Text == "")
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                else if (!File.Exists(tbProfiles_Edit_JVM_Path.Text))
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                else if (!tbProfiles_Edit_JVM_Path.Text.EndsWith("\\bin\\javaw.exe"))
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }

                try
                {
                    if (Path.IsPathRooted(tbProfiles_Edit_Directory.Text))
                    {
                        Path.GetFullPath(tbProfiles_Edit_Directory.Text);
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    }
                }
                catch (Exception)
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                }

                dynamic profilejson;
                Dictionary<string, Dictionary<string, object>> profiles;

                if (File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"))
                {
                    profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));
                    Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);
                    profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
                }
                else
                {
                    profiles = new Dictionary<string, Dictionary<string, object>>();
                }

                Dictionary<string, object> profile = new Dictionary<string, object>();
                
                profile.Add("mcversion", edit_version);
                profile.Add("gamedir", edit_directory);
                profile.Add("javapath", edit_jvm_path);
                profile.Add("javaargs", edit_jvm_args);
                profile.Add("offline-mode", edit_offline);
                profile.Add("offline-mode-playername", edit_offline_playername);

                profiles.Remove(edit_name);
                profiles.Add(edit_name, profile);

                string json = JsonConvert.SerializeObject(profiles);
                File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json", json);

                this.SafeInvoke(new Action(() =>
                {
                    cbProfiles_Select.Items.Clear();
                    cbFastControl_SelectProfile.Items.Clear();
                    foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
                    {
                        cbProfiles_Select.Items.Add(newProfile.Key);
                        cbFastControl_SelectProfile.Items.Add(newProfile.Key);
                    }
                    cbProfiles_Select.Items.Add("");
                    cbProfiles_Select.Items.Add("Create new profile");
                }));
            }).Start();
        }

        private void btnProfile_Edit_SaveNew_Click(object sender, EventArgs e)
        {
            string __version = cbProfiles_Edit_Version.Items[cbProfiles_Edit_Version.SelectedIndex] as string;
            string __dir = tbProfiles_Edit_Directory.Text;
            string __jvmpath = tbProfiles_Edit_JVM_Path.Text;
            string __jvmargs = tbProfiles_Edit_JVM_Args.Text;
            bool   __isoffline = toggleProfiles_Edit_Offline.Checked;
            string __offlinename = tbProfiles_Edit_Offline_PlayerName.Text;

            new Thread(() =>
            {
                if (tbProfiles_Edit_Name.Text == "")
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) profile name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                if (tbProfiles_Edit_Directory.Text == "")
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                if (tbProfiles_Edit_JVM_Path.Text == "")
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                else if (!File.Exists(tbProfiles_Edit_JVM_Path.Text))
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }
                else if (!tbProfiles_Edit_JVM_Path.Text.EndsWith("\\bin\\javaw.exe"))
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    return;
                }

                try
                {
                    if (Path.IsPathRooted(tbProfiles_Edit_Directory.Text))
                    {
                        Path.GetFullPath(tbProfiles_Edit_Directory.Text);
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                    }
                }
                catch (Exception)
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)));
                }

                dynamic profilejson;
                if (File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"))
                {
                    profilejson = File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json");
                }
                else
                {
                    profilejson = "{ }";
                }

                Dictionary<string, object> profile = new Dictionary<string, object>();
                Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)JsonConvert.DeserializeObject(profilejson); ;
                Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();

                profile.Add("mcversion", __version);
                profile.Add("gamedir", __dir);
                profile.Add("javapath", __jvmpath);
                profile.Add("javaargs", __jvmargs);
                profile.Add("offline-mode", __isoffline);
                profile.Add("offline-mode-playername", __offlinename);

                if (profiles.ContainsKey(tbProfiles_Edit_Name.Text))
                {
                    profiles.Remove(tbProfiles_Edit_Name.Text);
                    profiles.Add(tbProfiles_Edit_Name.Text, profile);
                }
                else
                {
                    profiles.Add(tbProfiles_Edit_Name.Text, profile);
                }

                string json = JsonConvert.SerializeObject(profiles);
                File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json", json);

                this.SafeInvoke(new Action(() =>
                {
                    cbProfiles_Select.Items.Clear();
                    cbFastControl_SelectProfile.Items.Clear();
                    foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
                    {
                        cbProfiles_Select.Items.Add(newProfile.Key);
                        cbFastControl_SelectProfile.Items.Add(newProfile.Key);
                    }
                    cbProfiles_Select.Items.Add("");
                    cbProfiles_Select.Items.Add("Create new profile");
                }));
            }).Start();
        }
        
        private void btnProfiles_Edit_Directory_Select_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a game directory";
                fbd.ShowNewFolderButton = true;
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tbProfiles_Edit_JVM_Args.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnProfiles_Edit_JVM_Path_Select_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select javaw.exe";
                ofd.Filter = "javaw.exe|javaw.exe";
                ofd.Multiselect = false;
                if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tbProfiles_Edit_JVM_Path.Text = ofd.FileName;
                }
            }
        }

        private void cbProfiles_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbProfiles_Select.SelectedIndex == (cbProfiles_Select.Items.Count - 2))
            {
                cbProfiles_Select.SelectedIndex = cbProfiles_Select.Items.Count - 1;
                btnProfile_Edit_Save.Text = "Create profile";
                btnProfile_Edit_SaveNew.Enabled = false;
                btnProfile_Edit_Delete.Enabled = false;
            }
            else if (cbProfiles_Select.SelectedIndex == (cbProfiles_Select.Items.Count - 1))
            {
                btnProfile_Edit_Save.Text = "Create profile";
                btnProfile_Edit_SaveNew.Enabled = false;
                btnProfile_Edit_Delete.Enabled = false;
            }
            else
            {
                dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));

                Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);
                Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();

                foreach (KeyValuePair<string, Dictionary<string, object>> profile in profiles)
                {
                    if (profile.Key == (string)cbProfiles_Select.Items[cbProfiles_Select.SelectedIndex])
                    {
                        tbProfiles_Edit_Name.Text = profile.Key;
                        cbProfiles_Edit_Version.SelectedItem = profile.Value["mcversion"];
                        tbProfiles_Edit_Directory.Text = profile.Value["gamedir"].ToString();
                        tbProfiles_Edit_JVM_Path.Text = profile.Value["javapath"].ToString();
                        tbProfiles_Edit_JVM_Args.Text = profile.Value["javaargs"].ToString();
                        tbProfiles_Edit_Offline_PlayerName.Text = profile.Value["offline-mode-playername"].ToString();
                        toggleProfiles_Edit_Offline.Checked = (bool)profile.Value["offline-mode"];
                    }
                }

                btnProfile_Edit_Save.Text = "Save profile";
                btnProfile_Edit_Delete.Enabled = true;
                btnProfile_Edit_SaveNew.Enabled = true;
            }
        }
                   
        private void toggleProfiles_Edit_ShowVersion_CheckedChanged(object sender, EventArgs e)
        {
            cbProfiles_Edit_Version.Items.Clear();
            cbProfiles_Edit_Version.Enabled = false;

            new Thread(() =>
            {
                if (toggleProfiles_Edit_ShowVersion_Release.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Release);
                    foreach (string version in versions)
                    {
                        this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Snapshot.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Snapshot);
                    foreach (string version in versions)
                    {
                        this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Beta.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Beta);
                    foreach (string version in versions)
                    {
                        this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Alpha.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Alpha);
                    foreach (string version in versions)
                    {
                        this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Custom.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Custom);
                    foreach (string version in versions)
                    {
                        this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }

                this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Enabled = true));
            }).Start();
        }
        
        private void toggleProfiles_Edit_Offline_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleProfiles_Edit_Offline.Checked)
            {
                lblProfiles_Edit_Offline_PlayerName.Enabled = true;
                tbProfiles_Edit_Offline_PlayerName.Enabled = true;
            }
            else
            {
                lblProfiles_Edit_Offline_PlayerName.Enabled = false;
                tbProfiles_Edit_Offline_PlayerName.Enabled = false;
            }
        }
        
        #endregion

        #region FastControl

        private void cbFastControl_SelectProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFastControl_SelectProfile.SelectedItem == null) return;

            dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));
            Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);

            Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
            foreach (KeyValuePair<string, Dictionary<string, object>> profile in profiles)
            {
                if(profile.Key == (string)cbFastControl_SelectProfile.Items[cbFastControl_SelectProfile.SelectedIndex])
                {
                    btnLaunch.Text = "Start Minecraft " + profile.Value["mcversion"];
                    currentProfile = profile;
                    if((bool)currentProfile.Value["offline-mode"] || session.LoggedIn)
                    {
                        btnLaunch.Enabled = true;
                    }
                    else
                    {
                        btnLaunch.Enabled = false;
                    }

                    if((bool)currentProfile.Value["offline-mode"])
                    {
                        session.OfflineModePlayerName = (string)currentProfile.Value["offline-mode-playername"];
                    }
                }
            }
        }

        private void btnFastLogin_Login_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Trying to login")));
                session = new MinecraftSession(tbFastLogin_Username.Text, tbFastLogin_Password.Text);
                if (session.LoggedIn)
                {
                    this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Logged in as " + session.PlayerName)));
                    this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Session: " + session.Session)));

                    new Thread(() =>
                    {
                        try
                        {
                            string type = "avatar";

                            if (head_type == 1)
                                type = "avatar";
                            else if (head_type == 2)
                                type = "helm";
                            else if (head_type == 3)
                                type = "cube";

                            new System.Net.WebClient().DownloadFile("https://minotar.net/" + type + "/" + session.PlayerName + "/64.png", GlobalConfig.AppDataPath +
                                "\\.minecraft\\minelauncher\\head\\" + session.PlayerName + ".png");
                            Icon headIcon = Icon.FromHandle(new Bitmap(Image.FromFile(GlobalConfig.AppDataPath +
                                "\\.minecraft\\minelauncher\\head\\" + session.PlayerName + ".png"), new Size(64, 64)).GetHicon());
                            this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Got player's head")));

                            this.BeginInvoke(new Action(() =>
                            {
                                pbFastInfo_Avatar.Image = headIcon.ToBitmap();
                            }));
                        }
                        catch (WebException)
                        {
                            this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Error while getting player's head")));
                        }
                    }).Start();

                    this.SafeInvoke(new Action(() => 
                    {
                        tbFastLogin_Password.Text = "";
                        tbFastLogin_Username.Text = "";
                        lblFastInfo_Welcome.Text = String.Format(lblFastInfo_Welcome.Text, session.PlayerName);
                        this.pnlFastLogin.Enabled = false;
                        this.pnlFastLogin.Visible = false;
                        pnlFastInfo.Visible = true;
                    }));
                    for (int i = 0; i < 26; i++)
                    {
                        this.SafeInvoke(new Action(() => pnlFastControl.Height -= 1));
                        this.SafeInvoke(new Action(() => pnlFastControl.Location = new System.Drawing.Point(pnlFastControl.Location.X, pnlFastControl.Location.Y + 1)));
                        this.SafeInvoke(new Action(() => tcMain.Height += 1));
                        Thread.Sleep(15);
                    }
                }
                else
                {
                    this.SafeInvoke(new Action(() => AddLogEntry("[LOGIN] Couldn't login, please try again")));
                    MetroFramework.MetroMessageBox.Show(this, "Login failed.\nCheck your internet connection and your entered username and password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }).Start();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 1;
            btnLaunch.Enabled = false;
            if (!currentProfile.Equals(default(KeyValuePair<string, Dictionary<string, object>>)))
            {
                new Thread(() =>
                {
                    this.SafeInvoke(new Action(() => AddLogEntry("[LAUNCHER] Download libararies/assets and preparing launcher...")));       
                    new DirectoryInfo(currentProfile.Value["gamedir"].ToString()).CreateDirectoryStructure();

                    MinecraftDownloader downloader = new MinecraftDownloader(currentProfile.Value["mcversion"].ToString());
                    downloader.OnDownload += ((object downloadsender, DownloadEventArgs downloade) =>
                    {
                        //this.Invoke => 
                        this.SafeInvoke(new Action(() => 
                        {
                            AddLogEntry("[DOWNLOADER] Downloading " + downloade.DownloadingFile + " (" + downloade.DownloadMaximum.ToByteFormatted() + ")");
                            pbLog.Maximum = downloade.DownloadMaximum;
                            pbLog.Value = downloade.DownloadCurrent;
                            lblLogPB.Text = "Downloading " + downloade.DownloadingFile;

                            if (TaskbarManager.IsPlatformSupported)
                            {
                                taskbar.SetProgressValue(downloade.DownloadCurrent, downloade.DownloadMaximum, this.Handle);
                            }
                        }));
                    });
                    downloader.StartDownload();
                    
                    this.SafeInvoke(new Action(() =>
                    {
                        pbLog.Maximum = 100;
                        pbLog.Value = 100;
                        lblLogPB.Text = "Download finished.";

                        if (TaskbarManager.IsPlatformSupported)
                        {
                            taskbar.SetProgressValue(0, 0, this.Handle);
                        }
                    }));

                    MinecraftLauncher launcher = new MinecraftLauncher(currentProfile.Key);
                    launcher.OnLauncherLog += ((object launchersender, LauncherEventArgs launchere) =>
                    {
                        this.SafeInvoke(new Action(() => AddLogEntry(launchere.Entry, launchere.MinecraftProcess)));
                    });

                    launcher.LaunchMC(this.session, this, (bool)currentProfile.Value["offline-mode"]);
                    this.SafeInvoke(new Action(() =>  btnLaunch.Enabled = true));
                }).Start();
            }
        }

        #endregion

        #region Settings
        
        private void btnSettings_ImportFromOriginalLauncher_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    dynamic mclauncher_profiles_json;
                    if(File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\launcher_profiles.json"))
                    {
                        mclauncher_profiles_json = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\launcher_profiles.json"));
                    }
                    else if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\launcher_profiles.json"))
                    {
                        if(MetroFramework.MetroMessageBox.Show(this, "Should I import the profiles from the standard Minecraft-Directory?", "Profile importer", MessageBoxButtons.YesNo) 
                            == System.Windows.Forms.DialogResult.Yes)
                        {
                            mclauncher_profiles_json = JsonConvert.DeserializeObject(File.ReadAllText(
                                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\launcher_profiles.json"));
                        }
                        else
                        {
                            throw new FileNotFoundException("User denies access to launcher_profiles.json");
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException("No launcher_profiles.json found.");
                    }
                
                    Newtonsoft.Json.Linq.JObject jTypeMCProfile = (Newtonsoft.Json.Linq.JObject)(mclauncher_profiles_json.profiles);
                    Dictionary<string, Dictionary<string, object>> mclauncher_profiles = jTypeMCProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
                
                    rawVersionList = VersionList.getVersionList(new System.Net.WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/versions.json"));
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Release);
                
                    dynamic profilejson;
                    if (File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"))
                    {
                        profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));
                    }
                    else
                    {
                        profilejson = JsonConvert.DeserializeObject("{ }");
                    }

                    Newtonsoft.Json.Linq.JObject jTypeMineLauncherProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);
                    Dictionary<string, Dictionary<string, object>> profiles;
                    if(jTypeMineLauncherProfile == null)
                    {
                        profiles = new Dictionary<string, Dictionary<string, object>>();
                    }
                    else
                    {
                        profiles = jTypeMineLauncherProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
                    }
                    
                    if (profiles == null) profiles = new Dictionary<string, Dictionary<string, object>>();

                    foreach(KeyValuePair<string, Dictionary<string, object>> mclauncher_profile in mclauncher_profiles)
                    {
                        Dictionary<string, object> minelauncher_profile_info = new Dictionary<string, object>();

                        if (mclauncher_profile.Value.ContainsKey("lastVersionId"))
                        {
                            minelauncher_profile_info.Add("mcversion", mclauncher_profile.Value["lastVersionId"]);
                        }
                        else
                        {
                            minelauncher_profile_info.Add("mcversion", versions[0]);
                        }

                        if(mclauncher_profile.Value.Count > 2)
                        {
                            minelauncher_profile_info.Add("gamedir", mclauncher_profile.Value["gameDir"]);
                            minelauncher_profile_info.Add("javapath", mclauncher_profile.Value["javaDir"]);
                            minelauncher_profile_info.Add("javaargs", mclauncher_profile.Value["javaArgs"]);
                            minelauncher_profile_info.Add("offline-mode", base_offline_mode);
                            minelauncher_profile_info.Add("offline-mode-playername", GenerateRandomNickName(9));

                            if (profiles.ContainsKey(mclauncher_profile.Key))
                            {
                                profiles.Remove(mclauncher_profile.Key);
                                profiles.Add(mclauncher_profile.Key, minelauncher_profile_info);
                            }
                            else
                            {
                                profiles.Add(mclauncher_profile.Key, minelauncher_profile_info);
                            } 
                        }
                    }

                    string json = JsonConvert.SerializeObject(profiles);
                    File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json", json);
                
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "The profiles of the original minecraft launcher were imported", "Import successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)));

                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Clear()));
                    this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Clear()));
                    foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
                    {
                        this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add(newProfile.Key)));
                        this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Add(newProfile.Key)));
                    }

                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("")));
                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
                }
                catch (Exception)
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "The import of the profiles failed", "Import failed", MessageBoxButtons.OK, MessageBoxIcon.Information)));
                }
            }).Start();
        }
        
        private void cbSettings_Themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSettings_Themes.SelectedIndex == 0)
            {
                this.uitheme = "Dark";
                cbSettings_CheckedChanged(sender, e);
                ChangeFormTheme(this);
            }
            else if(cbSettings_Themes.SelectedIndex == 1)
            {
                this.uitheme = "Light";
                cbSettings_CheckedChanged(sender, e);
                ChangeFormTheme(this);
            }
        }
    
        private void cbSettings_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dynamic setupjson;

                if (File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json"))
                    setupjson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json"));
                else
                    setupjson = JsonConvert.DeserializeObject("{ }");

                Newtonsoft.Json.Linq.JObject setupjsonObject = (Newtonsoft.Json.Linq.JObject)(setupjson);
                Dictionary<string, object> setup = setupjsonObject.ToObject<Dictionary<string, object>>();

                Newtonsoft.Json.Linq.JObject updaterjsonObject = (Newtonsoft.Json.Linq.JObject)(setup["updater"]);
                Dictionary<string, object> updater = updaterjsonObject.ToObject<Dictionary<string, object>>();
                Newtonsoft.Json.Linq.JObject ingamejsonObject = (Newtonsoft.Json.Linq.JObject)(setup["ingame"]);
                Dictionary<string, object> ingame = ingamejsonObject.ToObject<Dictionary<string, object>>();

                if (cbSettings_Themes.SelectedIndex == 0)
                    uitheme = "Dark";
                else if (cbSettings_Themes.SelectedIndex == 1)
                    uitheme = "Light";

                head_type = cbSettings_HeadSource.SelectedIndex + 1;

                // ######
                // Remove everything

                if (setup.ContainsKey("theme")) setup.Remove("theme");
                if (setup.ContainsKey("head")) setup.Remove("head");
                if (setup.ContainsKey("updater")) setup.Remove("updater");
                if (setup.ContainsKey("ingame")) setup.Remove("ingame");
                
                if (updater.ContainsKey("alpha")) updater.Remove("alpha");
                if (updater.ContainsKey("beta")) updater.Remove("beta");

                //
                // ######

                // ######
                // Readd everything

                updater.Add("alpha", cbSettings_Updater_Including_Alpha.Checked);
                updater.Add("beta", cbSettings_Updater_Including_Beta.Checked);

                setup.Add("head", cbSettings_HeadSource.SelectedIndex + 1);
                setup.Add("theme", cbSettings_Themes.SelectedItem.ToString());
                setup.Add("updater", updater);
                setup.Add("ingame", ingame);

                //
                // ######

                File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json", JsonConvert.SerializeObject(setup));
            }
            catch (NullReferenceException) { }
        }

        #region RandomNickGenerator

        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
        char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        int[] numbers = new int[] { 1, 3, 4, 6, 7, 8 };

        private string GenerateRandomNickName(int length)
        {
            StringBuilder sb = new StringBuilder();
            //initialize our vowel/consonant flag
            bool flag = (rand.Next(2) == 0);
            bool numbers1 = (rand.Next(4) == 2);
            bool numbers2 = (rand.Next(4) == 4);

            int middle_number_rand = rand.Next(44);

            if (numbers1)
            {
                sb.Append(numbers[rand.Next(numbers.Length)].ToString());
                sb.Append(numbers[rand.Next(numbers.Length)].ToString());
            }

            for (int i = 0; i < length; i++)
            {
                bool numbers_middle = (rand.Next(44) == middle_number_rand);
                if (numbers_middle) sb.Append(numbers[rand.Next(numbers.Length)].ToString());

                sb.Append(GetChar(flag));
                flag = !flag; //invert the vowel/consonant flag
            }

            if (numbers2)
            {
                sb.Append(numbers[rand.Next(numbers.Length)].ToString());
                sb.Append(numbers[rand.Next(numbers.Length)].ToString());
            }

            return sb.ToString();
        }

        private char GetChar(bool vowel)
        {
            if (vowel)
            {
                return vowels[rand.Next(vowels.Length)];
            }
            return consonants[rand.Next(consonants.Length)];
        }

        #endregion

        private void btnDonate_Click(object sender, EventArgs e)
        {
            string url = "";

            string business = "mail@lukasberger.at"; 
            string description = "MineLauncher-Donation";
            string country = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            string currency = "EUR";

            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";

            System.Diagnostics.Process.Start(url);
        }
                
        #endregion
                                                                                               
    }
}
