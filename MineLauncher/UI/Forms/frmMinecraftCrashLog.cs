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

    public partial class frmMinecraftCrashLog : MetroForm
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

            dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"));
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
            else
            {
                ctrl.BackColor = MetroFramework.Drawing.MetroPaint.BorderColor.Button.Normal(GetMetroThemeFromConfig());
                ctrl.ForeColor = MetroFramework.Drawing.MetroPaint.ForeColor.Button.Normal(GetMetroThemeFromConfig());
            }
            foreach (Control subctrl in ctrl.Controls)
            {
                if (subctrl is IMetroControl)
                {
                    ChangeControlTheme(subctrl);
                }
                else
                {
                    subctrl.BackColor = MetroFramework.Drawing.MetroPaint.BorderColor.Button.Normal(GetMetroThemeFromConfig());
                    subctrl.ForeColor = MetroFramework.Drawing.MetroPaint.ForeColor.Button.Normal(GetMetroThemeFromConfig());
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
        
    }

}
