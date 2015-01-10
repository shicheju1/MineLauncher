using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Interfaces;
using MetroFramework.Forms;

using MineLauncher;
using MineLauncher.Launcher;

using Newtonsoft.Json;
using Microsoft.Win32;

namespace MineLauncher.UI.Forms
{
    internal partial class frmSetup : MetroForm
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

        private void frmSetup_FormClosing(object sender, FormClosingEventArgs e)
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
             
        private void tileStartLauncher_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> setup = new Dictionary<string, object>();
            Dictionary<string, object> setup_updater = new Dictionary<string, object>();
            Dictionary<string, object> setup_ingame = new Dictionary<string, object>();

            setup.Add("baseofflinemode", toggleLogin_UseOfflineMode.Checked);
            setup.Add("theme", cbTheme.SelectedItem.ToString());

            setup_updater.Add("alpha", false);
            setup_updater.Add("beta", false);

            setup_ingame.Add("randomicon", true);
            setup_ingame.Add("changeiconrandom", true);

            setup.Add("updater", setup_updater);
            setup.Add("ingame", setup_ingame);

            File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json", JsonConvert.SerializeObject(setup));
            Application.Restart();
        }
        
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
            if (File.Exists(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"))
            {
                profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));
            }
            else
            {
                profilejson = new Dictionary<string, Dictionary<string, object>>();
            }

            Dictionary<string, object> profile = new Dictionary<string, object>();
            Dictionary<string, Dictionary<string, object>> profiles;

            if(File.Exists(""))
            {
                dynamic _profilejson = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json"));
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
            File.WriteAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\profiles.json", json);

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

                RegistryKey localmachine;

                if (Environment.Is64BitOperatingSystem)
                    localmachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                else
                    localmachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

                using (Microsoft.Win32.RegistryKey rk = localmachine.OpenSubKey(javaKey))
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
        
        private void btnProfiles_ImportFromOriginalLauncher_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                try
                {
                    dynamic mclauncher_profiles_json = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\launcher_profiles.json"));

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
                    if (jTypeMineLauncherProfile == null)
                    {
                        profiles = new Dictionary<string, Dictionary<string, object>>();
                    }
                    else
                    {
                        profiles = jTypeMineLauncherProfile.ToObject<Dictionary<string, Dictionary<string, object>>>();
                    }

                    if (profiles == null) profiles = new Dictionary<string, Dictionary<string, object>>();

                    foreach (KeyValuePair<string, Dictionary<string, object>> mclauncher_profile in mclauncher_profiles)
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

                        if (mclauncher_profile.Value.Count > 2)
                        {
                            minelauncher_profile_info.Add("gamedir", mclauncher_profile.Value["gameDir"]);
                            minelauncher_profile_info.Add("javapath", mclauncher_profile.Value["javaDir"]);
                            minelauncher_profile_info.Add("javaargs", mclauncher_profile.Value["javaArgs"]);
                            minelauncher_profile_info.Add("offline-mode", toggleLogin_UseOfflineMode.Checked);
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
                    this.SafeInvoke(new Action(() => tileProfile_Next.Enabled = true));
                }
                catch (Exception)
                {
                    this.SafeInvoke(new Action(() => MetroFramework.MetroMessageBox.Show(this, "The import of the profiles failed", "Import failed", MessageBoxButtons.OK, MessageBoxIcon.Information)));
                }
            }).Start();
        }

        #endregion
                
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

    }
}
