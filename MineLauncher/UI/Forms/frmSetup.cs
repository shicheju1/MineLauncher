using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Interfaces;
using MetroFramework.Forms;

using MineLauncher;
using MineLauncher.Launcher;

using Newtonsoft.Json;

namespace MineLauncher.UI.Forms
{
    public partial class frmSetup : MetroForm
    {

        string uitheme = "Dark";
        Dictionary<string, string[]> rawVersionList;
        Random rand = new Random();

        public frmSetup()
        {
            InitializeComponent();
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
        }
        
        private void frmSetup_Shown(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                rawVersionList = VersionList.getVersionList(new System.Net.WebClient().DownloadString("http://s3.amazonaws.com/Minecraft.Download/versions/versions.json"));
                List<string> versions = new VersionList().GetVersionList(rawVersionList, VersionListType.All);
                foreach (string version in versions)
                {
                    if (this.IsHandleCreated) this.Invoke(new Action(() => cbProfiles_Edit_Version.Items.Add(version)));
                }
            }).Start();
        }

        private void tileStartLauncher_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> setup = new Dictionary<string, object>();
            Dictionary<string, object> setup_updater = new Dictionary<string, object>();

            setup.Add("baseofflinemode", toggleLogin_UseOfflineMode.Checked);
            setup.Add("theme", cbTheme.SelectedItem.ToString());

            setup_updater.Add("alpha", false);
            setup_updater.Add("beta", false);

            setup.Add("updater", setup_updater);

            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json", JsonConvert.SerializeObject(setup));
            Application.Restart();
        }

        #region Theme
        
        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTheme.SelectedIndex == 0)
            {
                uitheme = "Dark";
            }
            else if (cbTheme.SelectedIndex == 1)
            {
                uitheme = "Light";
            }

            ChangeFormTheme(this);
        }

        public void ChangeFormTheme(MetroForm form)
        {
            form.Theme = GetMetroThemeFromConfig();
            this.Refresh();
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

                ctrl.Refresh();
                ChangeControlTheme(ctrl);
            }
        }

        private void ChangeControlTheme(Control ctrl)
        {
            if (ctrl is IMetroControl)
            {
                ((IMetroControl)ctrl).Theme = GetMetroThemeFromConfig();
                ctrl.Refresh();
            }
            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is IMetroControl)
                {
                    ChangeControlTheme(subctrl);
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
                ctrl.Refresh();
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

        #region Base control

        private void tileWelcome_Next_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 1;
        }

        private void tileTheme_Next_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 2;
        }

        private void tileTheme_Last_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 0;
        }
        
        private void tileLogin_Next_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 3;
        }

        private void tileLogin_Last_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 1;
        }

        private void tileProfile_Next_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 4;
        }

        private void tileProfile_Last_Click(object sender, EventArgs e)
        {
            tcMain.SelectedIndex = 2;
        }

        #endregion

        #region Login

        private void btnLogin_DoLogin_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                MinecraftSession session = new MinecraftSession(tbLogin_Username.Text, tbLogin_Password.Text);
                if (session.LoggedIn)
                {
                    this.Invoke(new Action(() =>
                    {
                        MetroFramework.MetroMessageBox.Show(this,
                            "MineLauncher logged in to your Minecraft-Account! You will be automatically logged in to your account if MineLauncher can do this",
                            "Logged in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tileLogin_Next.Enabled = true;
                    }));
                }
                else
                {
                    this.Invoke(new Action(() => {
                        MetroFramework.MetroMessageBox.Show(this, 
                            "MineLauncher couldn't login to your Minecraft-Account. Please check your internet connection and your username/password or select \"User Offline-Mode\"",
                            "Couldn't login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }

            }).Start();
        }

        private void toggleLogin_UseOfflineMode_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleLogin_UseOfflineMode.Checked)
            {
                tileLogin_Next.Enabled = true;

                lblProfiles_Edit_Offline_PlayerName.Visible = true;
                tbProfiles_Edit_Offline_PlayerName.Visible = true;
            }
            else
            {
                tileLogin_Next.Enabled = false;

                lblProfiles_Edit_Offline_PlayerName.Visible = false;
                tbProfiles_Edit_Offline_PlayerName.Visible = false;
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

            try
            {
                if (Path.IsPathRooted(tbProfiles_Edit_Directory.Text))
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
            Dictionary<string, Dictionary<string, object>> profiles;

            if(File.Exists(""))
            {
                dynamic _profilejson = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\profiles.json"));
                Newtonsoft.Json.Linq.JObject jTypeProfile = (Newtonsoft.Json.Linq.JObject)(_profilejson);

                profiles = jTypeProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
            }
            else
            {
                profiles = new Dictionary<string, Dictionary<string, object>>();
            }

            profile.Add("mcversion", cbProfiles_Edit_Version.Items[cbProfiles_Edit_Version.SelectedIndex]);
            profile.Add("gamedir", tbProfiles_Edit_Directory.Text);
            profile.Add("javapath", GetJavaInstallationPath() + "\\bin\\javaw.exe");
            profile.Add("javaargs", "-Xms1G -Xmx2G");
            profile.Add("offline-mode", toggleLogin_UseOfflineMode.Checked);
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

            tileProfile_Next.Enabled = true;
        }

        private string GetJavaInstallationPath()
        {
            string environmentPath = Environment.GetEnvironmentVariable("JAVA_HOME");
            if (!string.IsNullOrEmpty(environmentPath))
            {
                return environmentPath;
            }

            try
            {
                string javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment\\";
                using (Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(javaKey))
                {
                    string currentVersion = rk.GetValue("CurrentVersion").ToString();
                    using (Microsoft.Win32.RegistryKey key = rk.OpenSubKey(currentVersion))
                    {
                        return key.GetValue("JavaHome").ToString();
                    }
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "I probaly can say that you haven't installed java. Go to java.com and download the newest version", "Java isn't installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
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

        #endregion
                                           
    }
}
