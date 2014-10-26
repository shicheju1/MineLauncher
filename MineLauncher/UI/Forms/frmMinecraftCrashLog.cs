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

    internal partial class frmMinecraftCrashLog : MetroForm
    {

        string uitheme = "";

        string _crashlog = "";
        string _version = "";

        Random rand = new Random();

        public frmMinecraftCrashLog(string crashlog, string version)
        {
            InitializeComponent();

            List<System.Drawing.Icon> icons = new List<System.Drawing.Icon>();
            icons.Add(MineLauncher.Properties.Resources.Creeper_Blue);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Green);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Orange);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Red);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Standard);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Violet);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Yellow);

            this.Icon = icons[rand.Next(0, 6)];

            this._crashlog = crashlog;
            this._version = version;

            dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json"));
            uitheme = (string)setup.theme;
            ChangeFormTheme(this);
            
            this.rtbCrashLog.Font = MetroFonts.TextBox(MetroTextBoxSize.Medium, MetroTextBoxWeight.Bold);
        }
        
        private void frmMinecraftCrashLog_Shown(object sender, EventArgs e)
        {
            FileInfo report = new FileInfo(_crashlog);

            string[] file_name_parts = Path.GetFileNameWithoutExtension(report.Name).Split('-');

            string datetime = file_name_parts[1];
            string playing_type = file_name_parts[2];
            string title = "Sorry, but Minecraft " + _version + " crashed";

            string[] date_parts = datetime.Split('_')[0].Split('-');
            string[] time_parts = datetime.Split('_')[1].Split('.');
            string parsed_datetime = date_parts[2] + "." + date_parts[1] + "." + date_parts[0] + " " + time_parts[2] + ":" + time_parts[1] + ":" + time_parts[0];

            char[] playing_type_parts = playing_type.ToCharArray();
            playing_type_parts[0] = Char.Parse(playing_type_parts[0].ToString().ToUpper());
            playing_type = Convert.ToString(playing_type_parts);

            this.Text = title;
            this.lblDateTime.Text = parsed_datetime;
            this.lblPlayingType.Text = playing_type;
            this.rtbCrashLog.Text = File.ReadAllText(report.FullName);
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
        
    }

}
