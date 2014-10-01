using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Interfaces;
using MetroFramework.Forms;

using MineLauncher.Events;
using MineLauncher.Launcher;
using MineLauncher.Win32Api;

using Newtonsoft.Json;

namespace MineLauncher
{
    public partial class frmLauncher : MetroForm
    {

        string uitheme = "";
        Random rand = new Random();
        MinecraftSession session = null;
        KeyValuePair<string, Dictionary<string, object>> currentProfile = new KeyValuePair<string, Dictionary<string, object>>();
        Dictionary<string, string[]> rawVersionList = new Dictionary<string, string[]>();

        public frmLauncher()
        {
            InitializeComponent();

            DotMinecraft.CreateDotMinecraftHierarchy();

            MEMORYSTATUSEX memory = new MEMORYSTATUSEX();
            Calls.GlobalMemoryStatusEx(memory);
            
            rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [STARTUP] Starting MineLauncher Version " + Application.ProductVersion + "\n");
            rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [STARTUP] System: " + Environment.OSVersion.ToString() + "\n");
            rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [STARTUP] Memory: " + Math.Round((double)memory.ullTotalPhys / 1024 / 1024, 2) + "MB\n");

            if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"))
            {
                this.Enabled = false;
                new frmSetup().ShowDialog();
                this.Enabled = true;

                dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"));
                uitheme = (string)setup.theme;
                ChangeFormTheme(this);
            }
            else
            {
                dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"));
                uitheme = (string)setup.theme;
                ChangeFormTheme(this);
            }

            lblAbout.Text = String.Format(lblAbout.Text,
                Assembly.GetExecutingAssembly().GetName().Version.Major,
                Assembly.GetExecutingAssembly().GetName().Version.Minor,
                Assembly.GetExecutingAssembly().GetName().Version.Build,
                Assembly.GetExecutingAssembly().GetName().Version.Revision);
            
            tcMain.SelectedIndex = 0;

            List<System.Drawing.Icon> icons = new List<System.Drawing.Icon>();
            icons.Add(MineLauncher.Properties.Resources.Creeper_Blue);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Green);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Orange);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Red);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Standard);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Violet);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Yellow);

            this.Icon = icons[rand.Next(0, 6)];

            this.rtbLog.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold);
            this.rtbLog.BackColor = MetroFramework.Drawing.MetroPaint.BackColor.Button.Normal(MetroThemeStyle.Dark);
            this.rtbLog.ForeColor = MetroFramework.Drawing.MetroPaint.ForeColor.Button.Normal(MetroThemeStyle.Dark);

            this.rtbAbout_Licenses.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold);
            this.rtbAbout_Licenses.BackColor = MetroFramework.Drawing.MetroPaint.BackColor.Button.Normal(MetroThemeStyle.Dark);
            this.rtbAbout_Licenses.ForeColor = MetroFramework.Drawing.MetroPaint.ForeColor.Button.Normal(MetroThemeStyle.Dark);
        }
        
        private void frmLauncher_Shown(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Trying to login with saved session\n")));
                    session = MinecraftSession.LoginWithSavedSession();
                    if (session.LoggedIn)
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Logged in as " + session.PlayerName + "\n")));
                        if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Session: " + session.Session + "\n")));
                        new System.Net.WebClient().DownloadFile("https://minotar.net/avatar/" + session.PlayerName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor");
                        Icon headIcon = Icon.FromHandle(new Bitmap(Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor"), new Size(64, 64)).GetHicon());
                        if (this.IsHandleCreated) this.Invoke(new Action(() =>
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
                            if (this.IsHandleCreated) this.Invoke(new Action(() => pnlFastControl.Height -= 1));
                            if (this.IsHandleCreated) this.Invoke(new Action(() => pnlFastControl.Location = new System.Drawing.Point(pnlFastControl.Location.X, pnlFastControl.Location.Y + 1)));
                            if (this.IsHandleCreated) this.Invoke(new Action(() => tcMain.Height += 1));
                            Thread.Sleep(15);
                        }
                    }
                    else
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Couldn't login with saved session\n")));
                        if (this.IsHandleCreated) this.Invoke(new Action(() =>
                        {
                            this.pnlFastLogin.Enabled = true;
                        }));
                    }

                    rawVersionList = VersionList.getVersionList(new System.Net.WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/versions.json"));
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.All);
                    foreach (string version in versions)
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }

                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
                    {
                        dynamic profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
                        Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);

                        Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
                        foreach (KeyValuePair<string, Dictionary<string, object>> profile in profiles)
                        {
                            if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Select.Items.Add(profile.Key)));
                            if (this.IsHandleCreated) this.Invoke(new Action(() => cbFastControl_SelectProfile.Items.Add(profile.Key)));
                        }
                    }
                    if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Select.Items.Add("")));
                    if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
                }
                catch (System.Net.WebException)
                {
                }
                catch (Exception ex)
                {
                    Program.ExceptionTracker.Track(ex, true, false);
                }

            }).Start();
        }
        
        private void rtbLog_TextChanged(object sender, EventArgs e)
        {
            rtbLog.ScrollToCaret();

            string filename = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\logs\\" + DateTime.Now.ToShortDateString().Replace(".", "-") + ".log";
            File.AppendAllText(filename, rtbLog.Lines[rtbLog.Lines.Length - 1]);
        }
        
        #region ThemeChanger

        public void ChangeFormTheme(MetroForm form)
        {
            form.Theme = GetMetroThemeFromConfig();
            foreach (Control ctrl in ((Control)form).Controls)
            {
                if (ctrl is IMetroControl)
                {
                    ((IMetroControl)ctrl).Theme = GetMetroThemeFromConfig();
                }
                else if (ctrl is Control)
                {
                    if (GetMetroThemeFromConfig() == MetroThemeStyle.Dark)
                    {
                        ((Control)ctrl).BackColor = Color.FromArgb(17, 17, 17);
                        ((Control)ctrl).ForeColor = Color.FromArgb(170, 170, 170);
                    }
                    else
                    {
                        ((Control)ctrl).BackColor = Color.FromArgb(255, 255, 255);
                        ((Control)ctrl).ForeColor = Color.FromArgb(0, 0, 0);
                    }
                }

                ChangeControlTheme(ctrl);
            }
        }

        private void ChangeControlTheme(Control ctrl)
        {
            if (ctrl is IMetroControl)
            {
                ((IMetroControl)ctrl).Theme = GetMetroThemeFromConfig();
            }
            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is IMetroControl || subctrl is MetroLabel)
                {
                    ChangeControlTheme(subctrl);
                }
                else
                {
                    if (GetMetroThemeFromConfig() == MetroThemeStyle.Dark)
                    {
                        ((Control)ctrl).BackColor = Color.FromArgb(17, 17, 17);
                        ((Control)ctrl).ForeColor = Color.FromArgb(170, 170, 170);
                    }
                    else
                    {
                        ((Control)ctrl).BackColor = Color.FromArgb(255, 255, 255);
                        ((Control)ctrl).ForeColor = Color.FromArgb(0, 0, 0);
                    }
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
            dynamic _profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
            Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(_profilejson);

            Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
            
            profiles.Remove(tbProfiles_Edit_Name.Text);

            string json = JsonConvert.SerializeObject(profiles);
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json", json);

            cbProfiles_Select.Items.Clear();
            cbFastControl_SelectProfile.Items.Clear();
            foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
            {
                cbProfiles_Select.Items.Add(newProfile.Key);
                cbFastControl_SelectProfile.Items.Add(newProfile.Key);
            }

            if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Select.Items.Add("")));
            if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
        }

        private void btnProfile_Edit_Save_Click(object sender, EventArgs e)
        {
            if (tbProfiles_Edit_Name.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) profile name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbProfiles_Edit_Directory.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbProfiles_Edit_JVM_Path.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!File.Exists(tbProfiles_Edit_JVM_Path.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!tbProfiles_Edit_JVM_Path.Text.EndsWith("\\bin\\javaw.exe"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) path to the javaw.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if(Path.IsPathRooted(tbProfiles_Edit_Directory.Text))
                {
                    Path.GetFullPath(tbProfiles_Edit_Directory.Text);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a (valid) directory for the game-files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dynamic profilejson;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"))
            {
                profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
            }
            else
            {
                profilejson = new Dictionary<string, Dictionary<string, object>>();
            }

            Dictionary<string, object> profile = new Dictionary<string, object>();
            /*Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(profilejson);
            Dictionary<string, Dictionary<string, object>> profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();*/
            Dictionary<string, Dictionary<string, object>> profiles = profilejson;

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

            cbProfiles_Select.Items.Clear();
            cbFastControl_SelectProfile.Items.Clear();
            foreach (KeyValuePair<string, Dictionary<string, object>> newProfile in profiles)
            {
                cbProfiles_Select.Items.Add(newProfile.Key);
                cbFastControl_SelectProfile.Items.Add(newProfile.Key);
            }

            if(this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Select.Items.Add("")));
            if(this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Select.Items.Add("Create new profile")));
        }

        private void cbProfiles_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbProfiles_Select.SelectedIndex == (cbProfiles_Select.Items.Count - 2))
            {
                cbProfiles_Select.SelectedIndex = cbProfiles_Select.Items.Count - 1;
                btnProfile_Edit_Save.Text = "Create profile";
                btnProfile_Edit_Delete.Enabled = false;
            }
            else if (cbProfiles_Select.SelectedIndex == (cbProfiles_Select.Items.Count - 1))
            {
                btnProfile_Edit_Save.Text = "Create profile";
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
                        toggleProfiles_Edit_Offline.Checked = (bool)profile.Value["offline-mode"];
                    }
                }

                btnProfile_Edit_Save.Text = "Save profile";
                btnProfile_Edit_Delete.Enabled = true;
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
                        if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Snapshot.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Snapshot);
                    foreach (string version in versions)
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Beta.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Beta);
                    foreach (string version in versions)
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Alpha.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Alpha);
                    foreach (string version in versions)
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }
                if (toggleProfiles_Edit_ShowVersion_Custom.Checked)
                {
                    List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.Custom);
                    foreach (string version in versions)
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                    }
                }

                if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Enabled = true));
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
                if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Trying to login\n")));
                session = new MinecraftSession(tbFastLogin_Username.Text, tbFastLogin_Password.Text);
                if (session.LoggedIn)
                {
                    if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Logged in as " + session.PlayerName + "\n")));
                    if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Session: " + session.Session + "\n")));

                    new System.Net.WebClient().DownloadFile("https://minotar.net/avatar/" + session.PlayerName, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor");
                    Icon headIcon = Icon.FromHandle(new Bitmap(Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                        "\\.minecraft\\minelauncher\\headwhichyoucanopenwitheveryimageditor"), new Size(64, 64)).GetHicon());
                    if(this.IsHandleCreated) this.Invoke(new Action(() => 
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
                        if(this.IsHandleCreated) this.Invoke(new Action(() => pnlFastControl.Height -= 1));
                        if(this.IsHandleCreated) this.Invoke(new Action(() => pnlFastControl.Location = new System.Drawing.Point(pnlFastControl.Location.X, pnlFastControl.Location.Y + 1)));
                        if(this.IsHandleCreated) this.Invoke(new Action(() => tcMain.Height += 1));
                        Thread.Sleep(15);
                    }
                }
                else
                {
                    if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LOGIN] Couldn't login, please try again\n")));
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
                    if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText("[" + DateTime.Now.ToString() + "] [LAUNCHER] Download libararies/assets and preparing launcher...")));       
                    new DirectoryInfo(currentProfile.Value["gamedir"].ToString()).CreateDirectoryStructure();

                    MinecraftDownloader downloader = new MinecraftDownloader(currentProfile.Value["mcversion"].ToString());
                    downloader.OnDownload += ((object downloadsender, DownloadEventArgs downloade) =>
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText(downloade.Entry + "\n")));                        
                    });
                    downloader.StartDownload();

                    MinecraftLauncher launcher = new MinecraftLauncher(currentProfile.Key);
                    launcher.OnLauncherLog += ((object launchersender, LauncherEventArgs launchere) =>
                    {
                        if (this.IsHandleCreated) this.Invoke(new Action(() => rtbLog.AppendText(launchere.Entry + "\n")));
                    });

                    launcher.LaunchMC(this.session, this, (bool)currentProfile.Value["offline-mode"]);
                    if (this.IsHandleCreated) this.Invoke(new Action(() =>  btnLaunch.Enabled = true));
                }).Start();
            }
        }

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
