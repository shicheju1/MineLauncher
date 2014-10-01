namespace MineLauncher
{
    partial class frmLauncher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
            this.tcMain = new MetroFramework.Controls.MetroTabControl();
            this.tpStart = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tpConsole = new MetroFramework.Controls.MetroTabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpProfiles = new MetroFramework.Controls.MetroTabPage();
            this.pnlProfiles_Edit = new MetroFramework.Controls.MetroPanel();
            this.lblProfiles_Edit_Offline_PlayerName = new MetroFramework.Controls.MetroLabel();
            this.tbProfiles_Edit_Offline_PlayerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_Offline = new MetroFramework.Controls.MetroToggle();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Custom = new MetroFramework.Controls.MetroToggle();
            this.btnProfile_Edit_Delete = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Alpha = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Beta = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Snapshot = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Release = new MetroFramework.Controls.MetroToggle();
            this.btnProfile_Edit_Save = new MetroFramework.Controls.MetroButton();
            this.tbProfiles_Edit_JVM_Args = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbProfiles_Edit_JVM_Path = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbProfiles_Edit_Directory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbProfiles_Edit_Name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbProfiles_Edit_Version = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbProfiles_Select = new MetroFramework.Controls.MetroComboBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblAbout = new MetroFramework.Controls.MetroLabel();
            this.rtbAbout_Licenses = new System.Windows.Forms.RichTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.pnlFastControl = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cbFastControl_SelectProfile = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pnlFastInfo = new MetroFramework.Controls.MetroPanel();
            this.lblFastInfo_Welcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.pbFastInfo_Avatar = new System.Windows.Forms.PictureBox();
            this.pnlFastLogin = new MetroFramework.Controls.MetroPanel();
            this.tbFastLogin_Password = new MetroFramework.Controls.MetroTextBox();
            this.btnFastLogin_Login = new MetroFramework.Controls.MetroButton();
            this.tbFastLogin_Username = new MetroFramework.Controls.MetroTextBox();
            this.btnLaunch = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tcMain.SuspendLayout();
            this.tpStart.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.tpProfiles.SuspendLayout();
            this.pnlProfiles_Edit.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.pnlFastControl.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pnlFastInfo.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFastInfo_Avatar)).BeginInit();
            this.pnlFastLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpStart);
            this.tcMain.Controls.Add(this.tpConsole);
            this.tcMain.Controls.Add(this.tpProfiles);
            this.tcMain.Controls.Add(this.metroTabPage2);
            this.tcMain.Controls.Add(this.metroTabPage1);
            this.tcMain.Location = new System.Drawing.Point(23, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 3;
            this.tcMain.Size = new System.Drawing.Size(938, 414);
            this.tcMain.Style = MetroFramework.MetroColorStyle.Blue;
            this.tcMain.TabIndex = 0;
            this.tcMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcMain.UseSelectable = true;
            // 
            // tpStart
            // 
            this.tpStart.Controls.Add(this.webBrowser1);
            this.tpStart.HorizontalScrollbarBarColor = true;
            this.tpStart.HorizontalScrollbarHighlightOnWheel = false;
            this.tpStart.HorizontalScrollbarSize = 10;
            this.tpStart.Location = new System.Drawing.Point(4, 38);
            this.tpStart.Name = "tpStart";
            this.tpStart.Size = new System.Drawing.Size(930, 372);
            this.tpStart.TabIndex = 0;
            this.tpStart.Text = "Start";
            this.tpStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpStart.VerticalScrollbarBarColor = true;
            this.tpStart.VerticalScrollbarHighlightOnWheel = false;
            this.tpStart.VerticalScrollbarSize = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(924, 366);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://mcupdate.tumblr.com/", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.rtbLog);
            this.tpConsole.HorizontalScrollbarBarColor = true;
            this.tpConsole.HorizontalScrollbarHighlightOnWheel = false;
            this.tpConsole.HorizontalScrollbarSize = 10;
            this.tpConsole.Location = new System.Drawing.Point(4, 38);
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Size = new System.Drawing.Size(930, 372);
            this.tpConsole.TabIndex = 1;
            this.tpConsole.Text = "Console";
            this.tpConsole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpConsole.VerticalScrollbarBarColor = true;
            this.tpConsole.VerticalScrollbarHighlightOnWheel = false;
            this.tpConsole.VerticalScrollbarSize = 10;
            // 
            // rtbLog
            // 
            this.rtbLog.AcceptsTab = true;
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbLog.DetectUrls = false;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(3, 3);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(924, 366);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // tpProfiles
            // 
            this.tpProfiles.Controls.Add(this.pnlProfiles_Edit);
            this.tpProfiles.Controls.Add(this.cbProfiles_Select);
            this.tpProfiles.HorizontalScrollbarBarColor = true;
            this.tpProfiles.HorizontalScrollbarHighlightOnWheel = false;
            this.tpProfiles.HorizontalScrollbarSize = 10;
            this.tpProfiles.Location = new System.Drawing.Point(4, 38);
            this.tpProfiles.Name = "tpProfiles";
            this.tpProfiles.Size = new System.Drawing.Size(930, 372);
            this.tpProfiles.TabIndex = 3;
            this.tpProfiles.Text = "Profiles";
            this.tpProfiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpProfiles.VerticalScrollbarBarColor = true;
            this.tpProfiles.VerticalScrollbarHighlightOnWheel = false;
            this.tpProfiles.VerticalScrollbarSize = 10;
            // 
            // pnlProfiles_Edit
            // 
            this.pnlProfiles_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfiles_Edit.Controls.Add(this.lblProfiles_Edit_Offline_PlayerName);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_Offline_PlayerName);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel12);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_Offline);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel11);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Custom);
            this.pnlProfiles_Edit.Controls.Add(this.btnProfile_Edit_Delete);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel9);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Alpha);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel8);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Beta);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel7);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Snapshot);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel6);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Release);
            this.pnlProfiles_Edit.Controls.Add(this.btnProfile_Edit_Save);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_JVM_Args);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel5);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_JVM_Path);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel4);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_Directory);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel3);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_Name);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel2);
            this.pnlProfiles_Edit.Controls.Add(this.cbProfiles_Edit_Version);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel1);
            this.pnlProfiles_Edit.HorizontalScrollbarBarColor = true;
            this.pnlProfiles_Edit.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfiles_Edit.HorizontalScrollbarSize = 10;
            this.pnlProfiles_Edit.Location = new System.Drawing.Point(3, 41);
            this.pnlProfiles_Edit.Name = "pnlProfiles_Edit";
            this.pnlProfiles_Edit.Size = new System.Drawing.Size(924, 328);
            this.pnlProfiles_Edit.TabIndex = 3;
            this.pnlProfiles_Edit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlProfiles_Edit.VerticalScrollbarBarColor = true;
            this.pnlProfiles_Edit.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfiles_Edit.VerticalScrollbarSize = 10;
            // 
            // lblProfiles_Edit_Offline_PlayerName
            // 
            this.lblProfiles_Edit_Offline_PlayerName.AutoSize = true;
            this.lblProfiles_Edit_Offline_PlayerName.Location = new System.Drawing.Point(584, 240);
            this.lblProfiles_Edit_Offline_PlayerName.Name = "lblProfiles_Edit_Offline_PlayerName";
            this.lblProfiles_Edit_Offline_PlayerName.Size = new System.Drawing.Size(165, 19);
            this.lblProfiles_Edit_Offline_PlayerName.TabIndex = 29;
            this.lblProfiles_Edit_Offline_PlayerName.Text = "Offline-Mode playername:";
            this.lblProfiles_Edit_Offline_PlayerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_Offline_PlayerName
            // 
            this.tbProfiles_Edit_Offline_PlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfiles_Edit_Offline_PlayerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_Offline_PlayerName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_Offline_PlayerName.Lines = new string[] {
        "Notch"};
            this.tbProfiles_Edit_Offline_PlayerName.Location = new System.Drawing.Point(755, 237);
            this.tbProfiles_Edit_Offline_PlayerName.MaxLength = 32767;
            this.tbProfiles_Edit_Offline_PlayerName.Name = "tbProfiles_Edit_Offline_PlayerName";
            this.tbProfiles_Edit_Offline_PlayerName.PasswordChar = '\0';
            this.tbProfiles_Edit_Offline_PlayerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_Offline_PlayerName.SelectedText = "";
            this.tbProfiles_Edit_Offline_PlayerName.Size = new System.Drawing.Size(161, 24);
            this.tbProfiles_Edit_Offline_PlayerName.TabIndex = 28;
            this.tbProfiles_Edit_Offline_PlayerName.Text = "Notch";
            this.tbProfiles_Edit_Offline_PlayerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Offline_PlayerName.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(755, 210);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(73, 19);
            this.metroLabel12.TabIndex = 27;
            this.metroLabel12.Text = "Play offline";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_Offline
            // 
            this.toggleProfiles_Edit_Offline.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleProfiles_Edit_Offline.Checked = true;
            this.toggleProfiles_Edit_Offline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_Offline.DisplayStatus = false;
            this.toggleProfiles_Edit_Offline.Location = new System.Drawing.Point(834, 207);
            this.toggleProfiles_Edit_Offline.Name = "toggleProfiles_Edit_Offline";
            this.toggleProfiles_Edit_Offline.Size = new System.Drawing.Size(82, 24);
            this.toggleProfiles_Edit_Offline.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_Offline.TabIndex = 26;
            this.toggleProfiles_Edit_Offline.Text = "An";
            this.toggleProfiles_Edit_Offline.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_Offline.UseSelectable = true;
            this.toggleProfiles_Edit_Offline.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_Offline_CheckedChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(763, 43);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(95, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "Show \'Custom\'";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Custom
            // 
            this.toggleProfiles_Edit_ShowVersion_Custom.AutoSize = true;
            this.toggleProfiles_Edit_ShowVersion_Custom.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleProfiles_Edit_ShowVersion_Custom.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Custom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Custom.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Custom.Location = new System.Drawing.Point(864, 45);
            this.toggleProfiles_Edit_ShowVersion_Custom.Name = "toggleProfiles_Edit_ShowVersion_Custom";
            this.toggleProfiles_Edit_ShowVersion_Custom.Size = new System.Drawing.Size(50, 17);
            this.toggleProfiles_Edit_ShowVersion_Custom.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Custom.TabIndex = 24;
            this.toggleProfiles_Edit_ShowVersion_Custom.Text = "An";
            this.toggleProfiles_Edit_ShowVersion_Custom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Custom.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Custom.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // btnProfile_Edit_Delete
            // 
            this.btnProfile_Edit_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile_Edit_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfile_Edit_Delete.Location = new System.Drawing.Point(470, 278);
            this.btnProfile_Edit_Delete.Name = "btnProfile_Edit_Delete";
            this.btnProfile_Edit_Delete.Size = new System.Drawing.Size(220, 42);
            this.btnProfile_Edit_Delete.TabIndex = 23;
            this.btnProfile_Edit_Delete.Text = "Delete profile";
            this.btnProfile_Edit_Delete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_Delete.UseSelectable = true;
            this.btnProfile_Edit_Delete.Click += new System.EventHandler(this.btnProfile_Edit_Delete_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(607, 43);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "Show \'Alpha\'";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Alpha
            // 
            this.toggleProfiles_Edit_ShowVersion_Alpha.AutoSize = true;
            this.toggleProfiles_Edit_ShowVersion_Alpha.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleProfiles_Edit_ShowVersion_Alpha.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Alpha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Alpha.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Alpha.Location = new System.Drawing.Point(697, 45);
            this.toggleProfiles_Edit_ShowVersion_Alpha.Name = "toggleProfiles_Edit_ShowVersion_Alpha";
            this.toggleProfiles_Edit_ShowVersion_Alpha.Size = new System.Drawing.Size(50, 17);
            this.toggleProfiles_Edit_ShowVersion_Alpha.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Alpha.TabIndex = 20;
            this.toggleProfiles_Edit_ShowVersion_Alpha.Text = "An";
            this.toggleProfiles_Edit_ShowVersion_Alpha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Alpha.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Alpha.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(459, 43);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Show \'Beta\'";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Beta
            // 
            this.toggleProfiles_Edit_ShowVersion_Beta.AutoSize = true;
            this.toggleProfiles_Edit_ShowVersion_Beta.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleProfiles_Edit_ShowVersion_Beta.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Beta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Beta.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Beta.Location = new System.Drawing.Point(541, 45);
            this.toggleProfiles_Edit_ShowVersion_Beta.Name = "toggleProfiles_Edit_ShowVersion_Beta";
            this.toggleProfiles_Edit_ShowVersion_Beta.Size = new System.Drawing.Size(50, 17);
            this.toggleProfiles_Edit_ShowVersion_Beta.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Beta.TabIndex = 18;
            this.toggleProfiles_Edit_ShowVersion_Beta.Text = "An";
            this.toggleProfiles_Edit_ShowVersion_Beta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Beta.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Beta.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(279, 43);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(108, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Show \'Snapshots\'";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Snapshot
            // 
            this.toggleProfiles_Edit_ShowVersion_Snapshot.AutoSize = true;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Location = new System.Drawing.Point(393, 45);
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Name = "toggleProfiles_Edit_ShowVersion_Snapshot";
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Size = new System.Drawing.Size(50, 17);
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.TabIndex = 16;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Text = "An";
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(114, 43);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Show \'Release\'";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Release
            // 
            this.toggleProfiles_Edit_ShowVersion_Release.AutoSize = true;
            this.toggleProfiles_Edit_ShowVersion_Release.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleProfiles_Edit_ShowVersion_Release.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Release.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Release.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Release.Location = new System.Drawing.Point(213, 45);
            this.toggleProfiles_Edit_ShowVersion_Release.Name = "toggleProfiles_Edit_ShowVersion_Release";
            this.toggleProfiles_Edit_ShowVersion_Release.Size = new System.Drawing.Size(50, 17);
            this.toggleProfiles_Edit_ShowVersion_Release.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Release.TabIndex = 14;
            this.toggleProfiles_Edit_ShowVersion_Release.Text = "An";
            this.toggleProfiles_Edit_ShowVersion_Release.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Release.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Release.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // btnProfile_Edit_Save
            // 
            this.btnProfile_Edit_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile_Edit_Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfile_Edit_Save.Location = new System.Drawing.Point(696, 278);
            this.btnProfile_Edit_Save.Name = "btnProfile_Edit_Save";
            this.btnProfile_Edit_Save.Size = new System.Drawing.Size(220, 42);
            this.btnProfile_Edit_Save.TabIndex = 13;
            this.btnProfile_Edit_Save.Text = "Save profile";
            this.btnProfile_Edit_Save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_Save.UseSelectable = true;
            this.btnProfile_Edit_Save.Click += new System.EventHandler(this.btnProfile_Edit_Save_Click);
            // 
            // tbProfiles_Edit_JVM_Args
            // 
            this.tbProfiles_Edit_JVM_Args.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfiles_Edit_JVM_Args.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_JVM_Args.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_JVM_Args.Lines = new string[] {
        "-Xms1G -Xmx2G"};
            this.tbProfiles_Edit_JVM_Args.Location = new System.Drawing.Point(119, 177);
            this.tbProfiles_Edit_JVM_Args.MaxLength = 32767;
            this.tbProfiles_Edit_JVM_Args.Name = "tbProfiles_Edit_JVM_Args";
            this.tbProfiles_Edit_JVM_Args.PasswordChar = '\0';
            this.tbProfiles_Edit_JVM_Args.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_JVM_Args.SelectedText = "";
            this.tbProfiles_Edit_JVM_Args.Size = new System.Drawing.Size(797, 24);
            this.tbProfiles_Edit_JVM_Args.TabIndex = 12;
            this.tbProfiles_Edit_JVM_Args.Text = "-Xms1G -Xmx2G";
            this.tbProfiles_Edit_JVM_Args.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_JVM_Args.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 179);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Java arguments";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_JVM_Path
            // 
            this.tbProfiles_Edit_JVM_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfiles_Edit_JVM_Path.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_JVM_Path.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_JVM_Path.Lines = new string[] {
        "C:\\Program Files (x86)\\Java\\jre7\\bin\\javaw.exe"};
            this.tbProfiles_Edit_JVM_Path.Location = new System.Drawing.Point(119, 147);
            this.tbProfiles_Edit_JVM_Path.MaxLength = 32767;
            this.tbProfiles_Edit_JVM_Path.Name = "tbProfiles_Edit_JVM_Path";
            this.tbProfiles_Edit_JVM_Path.PasswordChar = '\0';
            this.tbProfiles_Edit_JVM_Path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_JVM_Path.SelectedText = "";
            this.tbProfiles_Edit_JVM_Path.Size = new System.Drawing.Size(797, 24);
            this.tbProfiles_Edit_JVM_Path.TabIndex = 10;
            this.tbProfiles_Edit_JVM_Path.Text = "C:\\Program Files (x86)\\Java\\jre7\\bin\\javaw.exe";
            this.tbProfiles_Edit_JVM_Path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_JVM_Path.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 149);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Java path";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_Directory
            // 
            this.tbProfiles_Edit_Directory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfiles_Edit_Directory.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_Directory.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_Directory.Lines = new string[] {
        "C:\\Minecraft\\My Profile"};
            this.tbProfiles_Edit_Directory.Location = new System.Drawing.Point(119, 114);
            this.tbProfiles_Edit_Directory.MaxLength = 32767;
            this.tbProfiles_Edit_Directory.Name = "tbProfiles_Edit_Directory";
            this.tbProfiles_Edit_Directory.PasswordChar = '\0';
            this.tbProfiles_Edit_Directory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_Directory.SelectedText = "";
            this.tbProfiles_Edit_Directory.Size = new System.Drawing.Size(797, 24);
            this.tbProfiles_Edit_Directory.TabIndex = 8;
            this.tbProfiles_Edit_Directory.Text = "C:\\Minecraft\\My Profile";
            this.tbProfiles_Edit_Directory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Directory.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 116);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Game directory";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_Name
            // 
            this.tbProfiles_Edit_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfiles_Edit_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_Name.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_Name.Lines = new string[] {
        "My Profile"};
            this.tbProfiles_Edit_Name.Location = new System.Drawing.Point(119, 81);
            this.tbProfiles_Edit_Name.MaxLength = 32767;
            this.tbProfiles_Edit_Name.Name = "tbProfiles_Edit_Name";
            this.tbProfiles_Edit_Name.PasswordChar = '\0';
            this.tbProfiles_Edit_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_Name.SelectedText = "";
            this.tbProfiles_Edit_Name.Size = new System.Drawing.Size(797, 24);
            this.tbProfiles_Edit_Name.TabIndex = 6;
            this.tbProfiles_Edit_Name.Text = "My Profile";
            this.tbProfiles_Edit_Name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Name.UseSelectable = true;
            this.tbProfiles_Edit_Name.TextChanged += new System.EventHandler(this.tbProfiles_Edit_Name_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Profile name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbProfiles_Edit_Version
            // 
            this.cbProfiles_Edit_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProfiles_Edit_Version.DropDownHeight = 230;
            this.cbProfiles_Edit_Version.FormattingEnabled = true;
            this.cbProfiles_Edit_Version.IntegralHeight = false;
            this.cbProfiles_Edit_Version.ItemHeight = 23;
            this.cbProfiles_Edit_Version.Location = new System.Drawing.Point(119, 8);
            this.cbProfiles_Edit_Version.Name = "cbProfiles_Edit_Version";
            this.cbProfiles_Edit_Version.Size = new System.Drawing.Size(797, 29);
            this.cbProfiles_Edit_Version.TabIndex = 4;
            this.cbProfiles_Edit_Version.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbProfiles_Edit_Version.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Minecraft Version";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbProfiles_Select
            // 
            this.cbProfiles_Select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProfiles_Select.DropDownHeight = 230;
            this.cbProfiles_Select.FormattingEnabled = true;
            this.cbProfiles_Select.IntegralHeight = false;
            this.cbProfiles_Select.ItemHeight = 23;
            this.cbProfiles_Select.Location = new System.Drawing.Point(3, 6);
            this.cbProfiles_Select.Name = "cbProfiles_Select";
            this.cbProfiles_Select.Size = new System.Drawing.Size(924, 29);
            this.cbProfiles_Select.TabIndex = 2;
            this.cbProfiles_Select.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbProfiles_Select.UseSelectable = true;
            this.cbProfiles_Select.SelectedIndexChanged += new System.EventHandler(this.cbProfiles_Select_SelectedIndexChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.lblAbout);
            this.metroTabPage2.Controls.Add(this.rtbAbout_Licenses);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(930, 372);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage2.TabIndex = 5;
            this.metroTabPage2.Text = "About";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(3, 3);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(223, 57);
            this.lblAbout.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "MineLauncher \r\nVersion {0}.{1} Build {2} Revision {3} \r\nby Lukas Berger, http://l" +
    "ukasberger.at";
            this.lblAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout.WrapToLine = true;
            // 
            // rtbAbout_Licenses
            // 
            this.rtbAbout_Licenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAbout_Licenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbout_Licenses.Location = new System.Drawing.Point(315, 3);
            this.rtbAbout_Licenses.Name = "rtbAbout_Licenses";
            this.rtbAbout_Licenses.Size = new System.Drawing.Size(612, 366);
            this.rtbAbout_Licenses.TabIndex = 2;
            this.rtbAbout_Licenses.Text = resources.GetString("rtbAbout_Licenses.Text");
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(930, 372);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage1.TabIndex = 4;
            this.metroTabPage1.Text = "Settings";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // pnlFastControl
            // 
            this.pnlFastControl.Controls.Add(this.metroPanel1);
            this.pnlFastControl.Controls.Add(this.pnlFastInfo);
            this.pnlFastControl.Controls.Add(this.pnlFastLogin);
            this.pnlFastControl.Controls.Add(this.btnLaunch);
            this.pnlFastControl.HorizontalScrollbarBarColor = true;
            this.pnlFastControl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFastControl.HorizontalScrollbarSize = 10;
            this.pnlFastControl.Location = new System.Drawing.Point(30, 476);
            this.pnlFastControl.Name = "pnlFastControl";
            this.pnlFastControl.Size = new System.Drawing.Size(924, 96);
            this.pnlFastControl.TabIndex = 1;
            this.pnlFastControl.VerticalScrollbarBarColor = true;
            this.pnlFastControl.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFastControl.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cbFastControl_SelectProfile);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(214, 96);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cbFastControl_SelectProfile
            // 
            this.cbFastControl_SelectProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFastControl_SelectProfile.FormattingEnabled = true;
            this.cbFastControl_SelectProfile.ItemHeight = 23;
            this.cbFastControl_SelectProfile.Location = new System.Drawing.Point(3, 42);
            this.cbFastControl_SelectProfile.Name = "cbFastControl_SelectProfile";
            this.cbFastControl_SelectProfile.Size = new System.Drawing.Size(208, 29);
            this.cbFastControl_SelectProfile.TabIndex = 3;
            this.cbFastControl_SelectProfile.UseSelectable = true;
            this.cbFastControl_SelectProfile.SelectedIndexChanged += new System.EventHandler(this.cbFastControl_SelectProfile_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 20);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Profile:";
            // 
            // pnlFastInfo
            // 
            this.pnlFastInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFastInfo.Controls.Add(this.lblFastInfo_Welcome);
            this.pnlFastInfo.Controls.Add(this.metroPanel3);
            this.pnlFastInfo.HorizontalScrollbarBarColor = true;
            this.pnlFastInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFastInfo.HorizontalScrollbarSize = 10;
            this.pnlFastInfo.Location = new System.Drawing.Point(729, 0);
            this.pnlFastInfo.Name = "pnlFastInfo";
            this.pnlFastInfo.Size = new System.Drawing.Size(195, 96);
            this.pnlFastInfo.TabIndex = 7;
            this.pnlFastInfo.VerticalScrollbarBarColor = true;
            this.pnlFastInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFastInfo.VerticalScrollbarSize = 10;
            this.pnlFastInfo.Visible = false;
            // 
            // lblFastInfo_Welcome
            // 
            this.lblFastInfo_Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFastInfo_Welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFastInfo_Welcome.Location = new System.Drawing.Point(64, 0);
            this.lblFastInfo_Welcome.Name = "lblFastInfo_Welcome";
            this.lblFastInfo_Welcome.Size = new System.Drawing.Size(131, 96);
            this.lblFastInfo_Welcome.TabIndex = 3;
            this.lblFastInfo_Welcome.Text = "Willkommen,\r\n{0}";
            this.lblFastInfo_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.pbFastInfo_Avatar);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(64, 96);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // pbFastInfo_Avatar
            // 
            this.pbFastInfo_Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFastInfo_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pbFastInfo_Avatar.Location = new System.Drawing.Point(0, 16);
            this.pbFastInfo_Avatar.MaximumSize = new System.Drawing.Size(64, 64);
            this.pbFastInfo_Avatar.MinimumSize = new System.Drawing.Size(64, 64);
            this.pbFastInfo_Avatar.Name = "pbFastInfo_Avatar";
            this.pbFastInfo_Avatar.Size = new System.Drawing.Size(64, 64);
            this.pbFastInfo_Avatar.TabIndex = 2;
            this.pbFastInfo_Avatar.TabStop = false;
            // 
            // pnlFastLogin
            // 
            this.pnlFastLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFastLogin.Controls.Add(this.tbFastLogin_Password);
            this.pnlFastLogin.Controls.Add(this.btnFastLogin_Login);
            this.pnlFastLogin.Controls.Add(this.tbFastLogin_Username);
            this.pnlFastLogin.Enabled = false;
            this.pnlFastLogin.HorizontalScrollbarBarColor = true;
            this.pnlFastLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFastLogin.HorizontalScrollbarSize = 10;
            this.pnlFastLogin.Location = new System.Drawing.Point(729, 0);
            this.pnlFastLogin.Name = "pnlFastLogin";
            this.pnlFastLogin.Size = new System.Drawing.Size(195, 96);
            this.pnlFastLogin.TabIndex = 6;
            this.pnlFastLogin.VerticalScrollbarBarColor = true;
            this.pnlFastLogin.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFastLogin.VerticalScrollbarSize = 10;
            // 
            // tbFastLogin_Password
            // 
            this.tbFastLogin_Password.Lines = new string[0];
            this.tbFastLogin_Password.Location = new System.Drawing.Point(5, 32);
            this.tbFastLogin_Password.MaxLength = 32767;
            this.tbFastLogin_Password.Name = "tbFastLogin_Password";
            this.tbFastLogin_Password.PasswordChar = '●';
            this.tbFastLogin_Password.PromptText = "Password";
            this.tbFastLogin_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFastLogin_Password.SelectedText = "";
            this.tbFastLogin_Password.Size = new System.Drawing.Size(187, 23);
            this.tbFastLogin_Password.TabIndex = 4;
            this.tbFastLogin_Password.UseSelectable = true;
            this.tbFastLogin_Password.UseSystemPasswordChar = true;
            // 
            // btnFastLogin_Login
            // 
            this.btnFastLogin_Login.Location = new System.Drawing.Point(5, 61);
            this.btnFastLogin_Login.Name = "btnFastLogin_Login";
            this.btnFastLogin_Login.Size = new System.Drawing.Size(187, 28);
            this.btnFastLogin_Login.TabIndex = 5;
            this.btnFastLogin_Login.Text = "Login";
            this.btnFastLogin_Login.UseSelectable = true;
            this.btnFastLogin_Login.Click += new System.EventHandler(this.btnFastLogin_Login_Click);
            // 
            // tbFastLogin_Username
            // 
            this.tbFastLogin_Username.Lines = new string[0];
            this.tbFastLogin_Username.Location = new System.Drawing.Point(5, 3);
            this.tbFastLogin_Username.MaxLength = 32767;
            this.tbFastLogin_Username.Name = "tbFastLogin_Username";
            this.tbFastLogin_Username.PasswordChar = '\0';
            this.tbFastLogin_Username.PromptText = "Username";
            this.tbFastLogin_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFastLogin_Username.SelectedText = "";
            this.tbFastLogin_Username.Size = new System.Drawing.Size(187, 23);
            this.tbFastLogin_Username.TabIndex = 3;
            this.tbFastLogin_Username.UseSelectable = true;
            // 
            // btnLaunch
            // 
            this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunch.Enabled = false;
            this.btnLaunch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLaunch.Location = new System.Drawing.Point(312, 3);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(300, 90);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Start Minecraft";
            this.btnLaunch.UseSelectable = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(6, 79);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(241, 76);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.White;
            this.metroLabel13.TabIndex = 4;
            this.metroLabel13.Text = "MetroFramework by Sven Walter\r\nExceptionBase.NET by Leo Bernard\r\nNewtonsoft.Json " +
    "by James Newton-King\r\nIonic.Zip by Dino Chiesa";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.WrapToLine = true;
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 595);
            this.Controls.Add(this.pnlFastControl);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(984, 595);
            this.MinimumSize = new System.Drawing.Size(984, 595);
            this.Name = "frmLauncher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "MineLauncher";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.frmLauncher_Shown);
            this.tcMain.ResumeLayout(false);
            this.tpStart.ResumeLayout(false);
            this.tpConsole.ResumeLayout(false);
            this.tpProfiles.ResumeLayout(false);
            this.pnlProfiles_Edit.ResumeLayout(false);
            this.pnlProfiles_Edit.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.pnlFastControl.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlFastInfo.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFastInfo_Avatar)).EndInit();
            this.pnlFastLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcMain;
        private MetroFramework.Controls.MetroTabPage tpStart;
        private MetroFramework.Controls.MetroTabPage tpConsole;
        private System.Windows.Forms.RichTextBox rtbLog;
        private MetroFramework.Controls.MetroTabPage tpProfiles;
        private MetroFramework.Controls.MetroPanel pnlProfiles_Edit;
        private MetroFramework.Controls.MetroComboBox cbProfiles_Select;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbProfiles_Edit_Version;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_Directory;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_Name;
        private MetroFramework.Controls.MetroButton btnProfile_Edit_Save;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_JVM_Args;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_JVM_Path;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroPanel pnlFastControl;
        private MetroFramework.Controls.MetroButton btnFastLogin_Login;
        private MetroFramework.Controls.MetroTextBox tbFastLogin_Password;
        private MetroFramework.Controls.MetroTextBox tbFastLogin_Username;
        private MetroFramework.Controls.MetroButton btnLaunch;
        private MetroFramework.Controls.MetroPanel pnlFastLogin;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Alpha;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Beta;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Snapshot;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Release;
        private MetroFramework.Controls.MetroPanel pnlFastInfo;
        private MetroFramework.Controls.MetroLabel lblFastInfo_Welcome;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.PictureBox pbFastInfo_Avatar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cbFastControl_SelectProfile;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnProfile_Edit_Delete;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Custom;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.RichTextBox rtbAbout_Licenses;
        private MetroFramework.Controls.MetroLabel lblAbout;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_Offline;
        private MetroFramework.Controls.MetroLabel lblProfiles_Edit_Offline_PlayerName;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_Offline_PlayerName;
        private MetroFramework.Controls.MetroLabel metroLabel13;
    }
}

