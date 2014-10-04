using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Interfaces;
using MetroFramework.Forms;

using Newtonsoft.Json;

namespace MineLauncher
{
    public partial class frmStarting : MetroForm
    {

        string uitheme = "";
        bool canClose = false;

        public frmStarting()
        {
            InitializeComponent();

            dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\minelauncher\\setup.json"));
            uitheme = (string)setup.theme;
            ChangeFormTheme(this);
        }

        public void CloseStartingDialog()
        {
            canClose = true;
            this.Close();
        }

        #region Theme
        
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

        private void frmStarting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose) e.Cancel = true;
        }

    }
}
