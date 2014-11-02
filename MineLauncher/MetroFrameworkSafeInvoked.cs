        public static void SafeInvoke(this Control uiElement, Action updater, bool forceSynchronous = true)
        {
            if (uiElement == null)
            {
                throw new ArgumentNullException("uiElement");
            }

            if (uiElement.InvokeRequired)
            {
                if (forceSynchronous)
                {
                    try
                    {
                        uiElement.Invoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                    }
                    catch (ObjectDisposedException)
                    {
                    }
                }
                else
                {
                    try
                    {
                        uiElement.BeginInvoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                    }
                    catch (ObjectDisposedException)
                    {
                    }
                }
            }
            else
            {
                if (!uiElement.IsDisposed)
                {
                    updater();
                }
            }
        }

private string uitheme = "Dark";
        
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