using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using MetroFramework.Forms;

using MineLauncher.Events;
using MineLauncher.Launcher;
using MineLauncher.Win32Api;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using nUpdate.Internal;

using Microsoft.WindowsAPICodePack.Taskbar;

namespace MineLauncher.UI.Forms
{
    public partial class frmLauncher : MetroForm
    {

        string uitheme = "";
        bool base_offline_mode = false;

        UpdateManager updater;
        UpdaterUI updaterui;
        bool updater_include_alpha = false;
        bool updater_include_beta = false;

        Random rand = new Random();
        MinecraftSession session = null;
        KeyValuePair<string, Dictionary<string, object>> currentProfile = new KeyValuePair<string, Dictionary<string, object>>();
        Dictionary<string, string[]> rawVersionList = new Dictionary<string, string[]>();

        TaskbarManager taskbar;

        frmStarting starting = new frmStarting();

        public frmLauncher()
        {
            InitializeComponent();

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"))
            {
                this.Enabled = false;
                new frmSetup().ShowDialog();
                this.Enabled = true;

                dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"));

                uitheme = (string)setup.theme;
                updater_include_alpha = (bool)setup.updater.alpha;
                updater_include_beta = (bool)setup.updater.beta;
                base_offline_mode = (bool)setup.baseofflinemode;

                ChangeFormTheme(this);
            }
            else
            {
                dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"));

                uitheme = (string)setup.theme;
                updater_include_alpha = (bool)setup.updater.alpha;
                updater_include_beta = (bool)setup.updater.beta;
                base_offline_mode = (bool)setup.baseofflinemode;

                ChangeFormTheme(this);
            }

            this.Location = new Point(-50000, -50000);
            this.ShowInTaskbar = false;
            starting.Show();

            new Thread(() =>
            {
                DotMinecraft.CreateDotMinecraftHierarchy();

                // nUpdate doesn't work yet

                

                /* this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [UPDATER] Searching for updates. This can take a while...\n")));
                updater = new UpdateManager(new Uri("http://update.lukasberger.at/minelauncher/updates.json"), MineLauncher.Properties.Resources.UpdaterPublicKey, new UpdateVersion(Application.ProductVersion));
                
                updater.IncludeAlpha = updater_include_alpha;
                updater.IncludeBeta = updater_include_beta;
                updater.UseHiddenSearch = true;

                updater.SearchForUpdates();

                if(updater.UpdatesFound)
                {
                    this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [UPDATER] Updates found, new Version is " + updater.UpdateVersion.ToString() + "\n")));
                    //this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [UPDATER] Updates will be installed soon...\n")));
                    this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [UPDATER] Sorry, but the installer can't install updates yet\n")));

                    //updater.InstallPackage();
                }
                else
                {
                    if(nUpdate.Core.ConnectionChecker.IsConnectionAvailable())
                    {
                        this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [UPDATER] No updates found\n")));
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [UPDATER] You must have an internet connection to check for updates\n")));
                    }
                } */

                MEMORYSTATUSEX memory = new MEMORYSTATUSEX();
                Calls.GlobalMemoryStatusEx(memory);

                ulong availMem = memory.ullAvailPhys;
                string memStat = "Fine";

                availMem = availMem / 1024 / 1024 / 1024;

                if (availMem <= 1)
                {
                    memStat = "Meh...";
                }
                else if (availMem <= 2)
                {
                    memStat = "More is recommended";
                }
                else if (availMem <= 4)
                {
                    memStat = "For playing with the standard-textures is enough";
                }
                else if (availMem <= 6)
                {
                    memStat = "Enough, maybe 128x-Textures";
                }
                else if (availMem <= 8)
                {
                    memStat = "Fine, but I won't use 512x-Textures";
                }

                if (availMem < 2)
                {
                    MetroFramework.MetroMessageBox.Show(this, "It's recommended to have 2 GB free memory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (availMem <= 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Sorry, but Minecraft can't run with less than 2 GB memory", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }

                this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [STARTUP] Starting MineLauncher Version " + Application.ProductVersion + "\n")));
                this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [STARTUP] System: " + Environment.OSVersion.GetOSFullName() + ", " + Environment.OSVersion.ToString() + "\n")));
                this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [STARTUP] Memory: " + Math.Round((double)memory.ullTotalPhys / 1024 / 1024, 2) + "MB\n")));
                this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [STARTUP] Available Memory: " + Math.Round((double)memory.ullAvailPhys / 1024 / 1024, 2) + "MB - " + memStat + "\n")));
                
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

                this.SafeInvoke(new Action(() => this.Icon = icons[rand.Next(0, 6)]));

                this.SafeInvoke(new Action(() => this.rtbLog.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold)));
                this.SafeInvoke(new Action(() => this.rtbAbout_Licenses.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold)));
            }).Start();
        }
        
        private void frmLauncher_Shown(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Trying to login with saved session\n")));
                    session = MinecraftSession.LoginWithSavedSession();
                    if (session.LoggedIn)
                    {
                        this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Logged in as " + session.PlayerName + "\n")));
                        this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Session: " + session.Session + "\n")));
                        new System.Net.WebClient().DownloadFile("https://minotar.net/avatar/" + session.PlayerName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor");
                        Icon headIcon = Icon.FromHandle(new Bitmap(Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor"), new Size(64, 64)).GetHicon());
                        this.BeginInvoke(new Action(() =>
                        {
                            tbFastLogin_Password.Text = "";
                            tbFastLogin_Username.Text = "";
                            pbFastInfo_Avatar.Image = headIcon.ToBitmap();
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
                        this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Couldn't login with saved session\n")));
                        this.BeginInvoke(new Action(() =>
                        {
                            this.pnlFastLogin.Enabled = true;
                        }));
                    }

                    rawVersionList = VersionList.getVersionList(new System.Net.WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/versions.json"));
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.All);
                    foreach (string version in versions)
                    {
                        this.SafeInvoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }

                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
                    {
                        dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
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
                catch (System.Net.WebException)
                {
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
                }));

            }).Start();
        }

        private void frmLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Preevent errors like ObjectDisposedException and so on
            Environment.Exit(0);
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void rtbLog_TextChanged(object sender, EventArgs e)
        {
            rtbLog.ScrollToCaret();

            string filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\logs\\" + DateTime.Now.ToShortDateString().Replace(".", "-") + ".log";
            if((rtbLog.Lines.Length - 1) >= 0) File.AppendAllText(filename, rtbLog.Lines[rtbLog.Lines.Length - 1]);
        }
        
        #region ThemeChanger

        public void ChangeFormTheme(MetroForm form)
        {
            form.Theme = GetMetroThemeFromConfig();
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
                        this.SafeInvoke(new Action(() => ((Control)ctrl).Refresh()));
                    }
                }

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
                this.SafeInvoke(new Action(() => ctrl.BackColor = MetroFramework.Drawing.MetroPaint.BorderColor.Button.Normal(GetMetroThemeFromConfig())));
                this.SafeInvoke(new Action(() => ctrl.ForeColor = MetroFramework.Drawing.MetroPaint.ForeColor.Button.Normal(GetMetroThemeFromConfig())));
                this.SafeInvoke(new Action(() => ctrl.Refresh()));
            }
            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is IMetroControl)
                {
                    ChangeControlTheme(subctrl);
                }
                else
                {
                    this.SafeInvoke(new Action(() => subctrl.BackColor = MetroFramework.Drawing.MetroPaint.BorderColor.Button.Normal(GetMetroThemeFromConfig())));
                    this.SafeInvoke(new Action(() => subctrl.ForeColor = MetroFramework.Drawing.MetroPaint.ForeColor.Button.Normal(GetMetroThemeFromConfig())));
                    this.SafeInvoke(new Action(() => subctrl.Refresh()));
                }
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

        #region Profile editor

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
                dynamic _profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
                Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(_profilejson);

                Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
            
                profiles.Remove(tbProfiles_Edit_Name.Text);

                string json = JsonConvert.SerializeObject(profiles);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json", json);

                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Clear()));
                this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Clear()));
                foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
                {
                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add(newProfile.Key)));
                    this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Add(newProfile.Key)));
                }

                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("")));
                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
            }).Start();
        }
        
        private void btnProfile_Edit_Save_Click(object sender, EventArgs e)
        {
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
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
                {
                    profilejson = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json");
                }
                else
                {
                    profilejson = "{ }";
                }

                Dictionary<string, object> profile = new Dictionary<string, object>();
                Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);
                Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();

                profile.Add("mcversion", cbProfiles_Edit_Version.Items[cbProfiles_Edit_Version.SelectedIndex]);
                profile.Add("gamedir", tbProfiles_Edit_Directory.Text);
                profile.Add("javapath", tbProfiles_Edit_JVM_Path.Text);
                profile.Add("javaargs", tbProfiles_Edit_JVM_Args.Text);
                profile.Add("offline-mode", toggleProfiles_Edit_Offline.Checked);
                profile.Add("offline-mode-playername", tbProfiles_Edit_Offline_PlayerName.Text);

                profiles.Remove(tbProfiles_Edit_Name.Text);
                profiles.Add(tbProfiles_Edit_Name.Text, profile);

                string json = JsonConvert.SerializeObject(profiles);
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json", json);

                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Clear()));
                this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Clear()));
                foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
                {
                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add(newProfile.Key)));
                    this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Add(newProfile.Key)));
                }

                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("")));
                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
            }).Start();
        }

        private void btnProfile_Edit_SaveNew_Click(object sender, EventArgs e)
        {
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
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
                {
                    profilejson = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json");
                }
                else
                {
                    profilejson = "{ }";
                }

                Dictionary<string, object> profile = new Dictionary<string, object>();
                Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);
                Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();

                profile.Add("mcversion", cbProfiles_Edit_Version.Items[cbProfiles_Edit_Version.SelectedIndex]);
                profile.Add("gamedir", tbProfiles_Edit_Directory.Text);
                profile.Add("javapath", tbProfiles_Edit_JVM_Path.Text);
                profile.Add("javaargs", tbProfiles_Edit_JVM_Args.Text);
                profile.Add("offline-mode", toggleProfiles_Edit_Offline.Checked);
                profile.Add("offline-mode-playername", tbProfiles_Edit_Offline_PlayerName.Text);

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
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json", json);

                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Clear()));
                this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Clear()));
                foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
                {
                    this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add(newProfile.Key)));
                    this.SafeInvoke(new Action(() => cbFastControl_SelectProfile.Items.Add(newProfile.Key)));
                }

                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("")));
                this.SafeInvoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
            }).Start();
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
                dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));

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

            dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
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
                this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Trying to login\n")));
                session = new MinecraftSession(tbFastLogin_Username.Text, tbFastLogin_Password.Text);
                if (session.LoggedIn)
                {
                    this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Logged in as " + session.PlayerName + "\n")));
                    this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Session: " + session.Session + "\n")));

                    new System.Net.WebClient().DownloadFile("https://minotar.net/avatar/" + session.PlayerName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor");
                    Icon headIcon = Icon.FromHandle(new Bitmap(Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor"), new Size(64, 64)).GetHicon());
                    this.SafeInvoke(new Action(() => 
                    {
                        tbFastLogin_Password.Text = "";
                        tbFastLogin_Username.Text = "";
                        pbFastInfo_Avatar.Image = headIcon.ToBitmap();
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
                    this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Couldn't login, please try again\n")));
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
                if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\versions\\" + currentProfile.Value["mcversion"].ToString()))
                {
                    MetroFramework.MetroMessageBox.Show(this, "This version doesn't exists. Maybe the profile was imported and the version was deleted", "Version missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                new Thread(() =>
                {
                    this.SafeInvoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LAUNCHER] Download libararies/assets and preparing launcher..." + "\n")));       
                    new DirectoryInfo(currentProfile.Value["gamedir"].ToString()).CreateDirectoryStructure();

                    MinecraftDownloader downloader = new MinecraftDownloader(currentProfile.Value["mcversion"].ToString());
                    downloader.OnDownload += ((object downloadsender, DownloadEventArgs downloade) =>
                    {
                        //this.Invoke => 
                        this.SafeInvoke(new Action(() => 
                        {
                            rtbLog.AppendText(downloade.Entry + "\n");
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

                    MinecraftLauncher launcher = new MinecraftLauncher(currentProfile.Key);
                    launcher.OnLauncherLog += ((object launchersender, LauncherEventArgs launchere) =>
                    {
                        this.SafeInvoke(new Action(() => rtbLog.AppendText(launchere.Entry + "\n")));
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
                    dynamic mclauncher_profiles_json = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\launcher_profiles.json"));
                
                    Newtonsoft.Json.Linq.JObject jTypeMCProfile = (Newtonsoft.Json.Linq.JObject)(mclauncher_profiles_json.profiles);
                    Dictionary<string, Dictionary<string, object>> mclauncher_profiles = jTypeMCProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
                
                    rawVersionList = VersionList.getVersionList(new System.Net.WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/versions.json"));
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Release);
                
                    dynamic profilejson;
                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
                    {
                        profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
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
                            minelauncher_profile_info.Add("offline-mode-playername", Generate(9));

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
                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json", json);
                
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
            dynamic setupjson;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
            {
                setupjson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
            }
            else
            {
                setupjson = JsonConvert.DeserializeObject("{ }");
            }

            Newtonsoft.Json.Linq.JObject setupjsonObject = (Newtonsoft.Json.Linq.JObject)(setupjson);
            Dictionary<string, object> setup = setupjsonObject.ToObject<Dictionary<string, object>>();

            if (cbSettings_Themes.SelectedIndex == 0)
            {
                uitheme = "Dark";
            }
            else if (cbSettings_Themes.SelectedIndex == 1)
            {
                uitheme = "Light";
            }
            
            setup.Remove("theme");
            setup.Add("theme", cbSettings_Themes.SelectedItem.ToString());

            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json", JsonConvert.SerializeObject(setup));

            ChangeFormTheme(this);
        }
        
        private void cbSettings_Updater_CheckedChanged(object sender, EventArgs e)
        {
            dynamic setupjson;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
            {
                setupjson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
            }
            else
            {
                setupjson = JsonConvert.DeserializeObject("{ }");
            }

            Newtonsoft.Json.Linq.JObject setupjsonObject = (Newtonsoft.Json.Linq.JObject)(setupjson);
            Dictionary<string, object> setup = setupjsonObject.ToObject<Dictionary<string, object>>();

            Dictionary<string, object> updater = (Dictionary<string, object>)(setup["updater"]);

            updater.Remove("alpha");
            updater.Remove("beta");

            updater.Add("alpha", cbSettings_Updater_Including_Alpha.Checked);
            updater.Add("beta", cbSettings_Updater_Including_Beta.Checked);

            setup.Remove("updater");
            setup.Add("updater", updater);

            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json", JsonConvert.SerializeObject(setup));
        }             

        #region RandomNickGenerator

        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
        char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        int[] numbers = new int[] { 1, 3, 4, 6, 7, 8 };

        private string Generate(int length)
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

        #endregion

        private void ConvertBitmapToIcon(Bitmap bmp, string path)
        {
            Icon ico = Icon.FromHandle(bmp.GetHicon());
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            ico.Save(fs);
            fs.Close();
        }
                           
    }
}
