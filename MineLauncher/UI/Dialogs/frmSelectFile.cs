using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using Newtonsoft.Json;

using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework.Interfaces;

namespace MineLauncher.UI.Dialogs
{
    public partial class frmSelectFile : MetroForm
    {

        string uitheme = "";
        Random rand = new Random();

        public frmSelectFile()
        {
            InitializeComponent();

            dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"));
            uitheme = (string)setup.theme;
            
            List<System.Drawing.Icon> icons = new List<System.Drawing.Icon>();
            icons.Add(MineLauncher.Properties.Resources.Creeper_Blue);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Green);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Orange);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Red);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Standard);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Violet);
            icons.Add(MineLauncher.Properties.Resources.Creeper_Yellow);

            this.Icon = icons[rand.Next(0, 6)];
            
            ChangeFormTheme(this);
        }
        
        #region ThemeChanger

        public void ChangeFormTheme(MetroForm form)
        {
            form.Theme = GetMetroThemeFromConfig();
            this.SafeInvoke(new Action(() => form.Refresh()));
            foreach (Control ctrl in ((Control)form).Controls)
            {
                if (ctrl is IMetroControl)
                {
                    this.SafeInvoke(new Action(() => ((IMetroControl)ctrl).Theme = GetMetroThemeFromConfig()));
                    this.SafeInvoke(new Action(() => ctrl.Refresh()));
                }
                else if (ctrl is Control)
                {
                    if (GetMetroThemeFromConfig() == MetroThemeStyle.Dark)
                    {
                        this.SafeInvoke(new Action(() => ctrl.BackColor = Color.FromArgb(17, 17, 17)));
                        this.SafeInvoke(new Action(() => ctrl.ForeColor = Color.FromArgb(170, 170, 170)));
                        this.SafeInvoke(new Action(() => ctrl.Refresh()));
                    }
                    else
                    {
                        this.SafeInvoke(new Action(() => ctrl.BackColor = Color.FromArgb(255, 255, 255)));
                        this.SafeInvoke(new Action(() => ctrl.ForeColor = Color.FromArgb(0, 0, 0)));
                        this.SafeInvoke(new Action(() => ctrl.Refresh()));
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
                this.SafeInvoke(new Action(() => ctrl.Refresh()));
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
                    this.SafeInvoke(new Action(() => ((IMetroControl)subctrl).Theme = GetMetroThemeFromConfig()));
                    this.SafeInvoke(new Action(() => subctrl.Refresh()));
                    ChangeControlTheme(subctrl);
                }
                else
                {
                    this.SafeInvoke(new Action(() => subctrl.BackColor = MetroFramework.Drawing.MetroPaint.BorderColor.Button.Normal(GetMetroThemeFromConfig())));
                    this.SafeInvoke(new Action(() => subctrl.ForeColor = MetroFramework.Drawing.MetroPaint.ForeColor.Button.Normal(GetMetroThemeFromConfig())));
                    this.SafeInvoke(new Action(() => subctrl.Refresh()));
                    ChangeControlTheme(subctrl);
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
