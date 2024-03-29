﻿using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Interfaces;
using MetroFramework.Forms;

using Newtonsoft.Json;

namespace MineLauncher
{
    internal partial class frmStarting : MetroForm
    {

        string uitheme = "";
        bool canClose = false;

        public frmStarting()
        {
            InitializeComponent();

            dynamic setup = JsonConvert.DeserializeObject(File.ReadAllText(GlobalConfig.AppDataPath + "\\.minecraft\\minelauncher\\setup.json"));
            uitheme = (string)setup.theme;
            ChangeFormTheme(this);

            Timer tmr = new Timer();
            tmr.Interval = 10000;
            tmr.Tick += ((object sender, EventArgs e) =>
            {
                lblInfo.Visible = true;
                tmr.Stop();
            });
            tmr.Start();
        }

        public void CloseStartingDialog()
        {
            canClose = true;
            this.Close();
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

        private void frmStarting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose)
                e.Cancel = true;
        }
                
    }
}
