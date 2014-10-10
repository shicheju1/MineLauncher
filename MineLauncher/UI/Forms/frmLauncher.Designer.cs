namespace MineLauncher.UI.Forms
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
            this.lblLogPB = new MetroFramework.Controls.MetroLabel();
            this.pbLog = new MetroFramework.Controls.MetroProgressBar();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpProfiles = new MetroFramework.Controls.MetroTabPage();
            this.pnlProfiles_Edit = new MetroFramework.Controls.MetroPanel();
            this.btnProfiles_Edit_JVM_Path_Select = new MetroFramework.Controls.MetroButton();
            this.btnProfiles_Edit_Directory_Select = new MetroFramework.Controls.MetroButton();
            this.btnProfile_Edit_Save = new MetroFramework.Controls.MetroButton();
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
            this.btnProfile_Edit_SaveNew = new MetroFramework.Controls.MetroButton();
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
            this.tpSettings = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds = new MetroFramework.Controls.MetroCheckBox();
            this.cbSettings_Launcher_ChangeGameIcon = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.cbSettings_Updater_Including_Beta = new MetroFramework.Controls.MetroCheckBox();
            this.cbSettings_Updater_Including_Alpha = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.cbSettings_Themes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSettings_ImportFromOriginalLauncher = new MetroFramework.Controls.MetroButton();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.tpAbout = new MetroFramework.Controls.MetroTabPage();
            this.lblAbout_WindowsApiCodePack = new MetroFramework.Controls.MetroLabel();
            this.lblAbout_nUpdate = new MetroFramework.Controls.MetroLabel();
            this.lblAbout_IonicZip = new MetroFramework.Controls.MetroLabel();
            this.lblAbout_NewtonsoftJson = new MetroFramework.Controls.MetroLabel();
            this.lblAbout_ExceptionBase = new MetroFramework.Controls.MetroLabel();
            this.linkAbout_GitHub = new MetroFramework.Controls.MetroLink();
            this.lblAbout_MetroFramework = new MetroFramework.Controls.MetroLabel();
            this.lblAbout = new MetroFramework.Controls.MetroLabel();
            this.rtbAbout_Licenses = new System.Windows.Forms.RichTextBox();
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
            this.tcMain.SuspendLayout();
            this.tpStart.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.tpProfiles.SuspendLayout();
            this.pnlProfiles_Edit.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tpAbout.SuspendLayout();
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
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Controls.Add(this.tpAbout);
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
            this.tpStart.Enabled = true;
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
            this.tpStart.Visible = false;
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
            this.tpConsole.Controls.Add(this.lblLogPB);
            this.tpConsole.Controls.Add(this.pbLog);
            this.tpConsole.Controls.Add(this.rtbLog);
            this.tpConsole.Enabled = true;
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
            this.tpConsole.Visible = false;
            // 
            // lblLogPB
            // 
            this.lblLogPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLogPB.BackColor = System.Drawing.Color.Transparent;
            this.lblLogPB.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLogPB.Location = new System.Drawing.Point(16, 345);
            this.lblLogPB.Name = "lblLogPB";
            this.lblLogPB.Size = new System.Drawing.Size(314, 15);
            this.lblLogPB.TabIndex = 4;
            // 
            // pbLog
            // 
            this.pbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLog.HideProgressText = false;
            this.pbLog.Location = new System.Drawing.Point(3, 333);
            this.pbLog.Name = "pbLog";
            this.pbLog.Size = new System.Drawing.Size(924, 39);
            this.pbLog.TabIndex = 3;
            // 
            // rtbLog
            // 
            this.rtbLog.AcceptsTab = true;
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.SystemColors.Window;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbLog.DetectUrls = false;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Location = new System.Drawing.Point(3, 3);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(924, 324);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // tpProfiles
            // 
            this.tpProfiles.Controls.Add(this.pnlProfiles_Edit);
            this.tpProfiles.Controls.Add(this.cbProfiles_Select);
            this.tpProfiles.Enabled = true;
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
            this.tpProfiles.Visible = false;
            // 
            // pnlProfiles_Edit
            // 
            this.pnlProfiles_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfiles_Edit.Controls.Add(this.btnProfiles_Edit_JVM_Path_Select);
            this.pnlProfiles_Edit.Controls.Add(this.btnProfiles_Edit_Directory_Select);
            this.pnlProfiles_Edit.Controls.Add(this.btnProfile_Edit_Save);
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
            this.pnlProfiles_Edit.Controls.Add(this.btnProfile_Edit_SaveNew);
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
            // btnProfiles_Edit_JVM_Path_Select
            // 
            this.btnProfiles_Edit_JVM_Path_Select.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnProfiles_Edit_JVM_Path_Select.Location = new System.Drawing.Point(892, 147);
            this.btnProfiles_Edit_JVM_Path_Select.Name = "btnProfiles_Edit_JVM_Path_Select";
            this.btnProfiles_Edit_JVM_Path_Select.Size = new System.Drawing.Size(24, 24);
            this.btnProfiles_Edit_JVM_Path_Select.TabIndex = 34;
            this.btnProfiles_Edit_JVM_Path_Select.Text = "...";
            this.btnProfiles_Edit_JVM_Path_Select.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfiles_Edit_JVM_Path_Select.UseSelectable = true;
            this.btnProfiles_Edit_JVM_Path_Select.Click += new System.EventHandler(this.btnProfiles_Edit_JVM_Path_Select_Click);
            // 
            // btnProfiles_Edit_Directory_Select
            // 
            this.btnProfiles_Edit_Directory_Select.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnProfiles_Edit_Directory_Select.Location = new System.Drawing.Point(892, 114);
            this.btnProfiles_Edit_Directory_Select.Name = "btnProfiles_Edit_Directory_Select";
            this.btnProfiles_Edit_Directory_Select.Size = new System.Drawing.Size(24, 24);
            this.btnProfiles_Edit_Directory_Select.TabIndex = 33;
            this.btnProfiles_Edit_Directory_Select.Text = "...";
            this.btnProfiles_Edit_Directory_Select.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfiles_Edit_Directory_Select.UseSelectable = true;
            this.btnProfiles_Edit_Directory_Select.Click += new System.EventHandler(this.btnProfiles_Edit_Directory_Select_Click);
            // 
            // btnProfile_Edit_Save
            // 
            this.btnProfile_Edit_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile_Edit_Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfile_Edit_Save.Location = new System.Drawing.Point(701, 283);
            this.btnProfile_Edit_Save.Name = "btnProfile_Edit_Save";
            this.btnProfile_Edit_Save.Size = new System.Drawing.Size(220, 42);
            this.btnProfile_Edit_Save.TabIndex = 30;
            this.btnProfile_Edit_Save.Text = "Save profile";
            this.btnProfile_Edit_Save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_Save.UseSelectable = true;
            this.btnProfile_Edit_Save.Click += new System.EventHandler(this.btnProfile_Edit_Save_Click);
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
            this.btnProfile_Edit_Delete.Location = new System.Drawing.Point(249, 283);
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
            // btnProfile_Edit_SaveNew
            // 
            this.btnProfile_Edit_SaveNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile_Edit_SaveNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfile_Edit_SaveNew.Location = new System.Drawing.Point(475, 283);
            this.btnProfile_Edit_SaveNew.Name = "btnProfile_Edit_SaveNew";
            this.btnProfile_Edit_SaveNew.Size = new System.Drawing.Size(220, 42);
            this.btnProfile_Edit_SaveNew.TabIndex = 13;
            this.btnProfile_Edit_SaveNew.Text = "Copy && Save profile";
            this.btnProfile_Edit_SaveNew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_SaveNew.UseMnemonic = false;
            this.btnProfile_Edit_SaveNew.UseSelectable = true;
            this.btnProfile_Edit_SaveNew.Click += new System.EventHandler(this.btnProfile_Edit_SaveNew_Click);
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
            this.tbProfiles_Edit_JVM_Path.Size = new System.Drawing.Size(767, 24);
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
            this.tbProfiles_Edit_Directory.Size = new System.Drawing.Size(767, 24);
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
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.metroPanel6);
            this.tpSettings.Controls.Add(this.metroPanel5);
            this.tpSettings.Controls.Add(this.metroPanel4);
            this.tpSettings.Controls.Add(this.metroPanel2);
            this.tpSettings.Enabled = true;
            this.tpSettings.HorizontalScrollbarBarColor = true;
            this.tpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSettings.HorizontalScrollbarSize = 10;
            this.tpSettings.Location = new System.Drawing.Point(4, 38);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(930, 372);
            this.tpSettings.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpSettings.TabIndex = 4;
            this.tpSettings.Text = "Settings";
            this.tpSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpSettings.VerticalScrollbarBarColor = true;
            this.tpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpSettings.VerticalScrollbarSize = 10;
            this.tpSettings.Visible = true;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds);
            this.metroPanel6.Controls.Add(this.cbSettings_Launcher_ChangeGameIcon);
            this.metroPanel6.Controls.Add(this.metroLabel13);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(6, 133);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(297, 124);
            this.metroPanel6.TabIndex = 6;
            this.metroPanel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds
            // 
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.AutoSize = true;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.Location = new System.Drawing.Point(18, 59);
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.Name = "cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds";
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.Size = new System.Drawing.Size(229, 15);
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.TabIndex = 7;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.Text = "Change Icon random every 5 seconds";
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.UseSelectable = true;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // cbSettings_Launcher_ChangeGameIcon
            // 
            this.cbSettings_Launcher_ChangeGameIcon.AutoSize = true;
            this.cbSettings_Launcher_ChangeGameIcon.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Launcher_ChangeGameIcon.Location = new System.Drawing.Point(3, 38);
            this.cbSettings_Launcher_ChangeGameIcon.Name = "cbSettings_Launcher_ChangeGameIcon";
            this.cbSettings_Launcher_ChangeGameIcon.Size = new System.Drawing.Size(129, 15);
            this.cbSettings_Launcher_ChangeGameIcon.TabIndex = 6;
            this.cbSettings_Launcher_ChangeGameIcon.Text = "Change Game-Icon";
            this.cbSettings_Launcher_ChangeGameIcon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Launcher_ChangeGameIcon.UseSelectable = true;
            this.cbSettings_Launcher_ChangeGameIcon.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(3, 6);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(291, 23);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "Launcher";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.cbSettings_Updater_Including_Beta);
            this.metroPanel5.Controls.Add(this.cbSettings_Updater_Including_Alpha);
            this.metroPanel5.Controls.Add(this.metroLabel16);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(615, 3);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(300, 124);
            this.metroPanel5.TabIndex = 5;
            this.metroPanel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // cbSettings_Updater_Including_Beta
            // 
            this.cbSettings_Updater_Including_Beta.AutoSize = true;
            this.cbSettings_Updater_Including_Beta.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Updater_Including_Beta.Location = new System.Drawing.Point(3, 59);
            this.cbSettings_Updater_Including_Beta.Name = "cbSettings_Updater_Including_Beta";
            this.cbSettings_Updater_Including_Beta.Size = new System.Drawing.Size(154, 15);
            this.cbSettings_Updater_Including_Beta.TabIndex = 4;
            this.cbSettings_Updater_Including_Beta.Text = "Including Beta-Versions";
            this.cbSettings_Updater_Including_Beta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Updater_Including_Beta.UseSelectable = true;
            this.cbSettings_Updater_Including_Beta.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // cbSettings_Updater_Including_Alpha
            // 
            this.cbSettings_Updater_Including_Alpha.AutoSize = true;
            this.cbSettings_Updater_Including_Alpha.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Updater_Including_Alpha.Location = new System.Drawing.Point(3, 38);
            this.cbSettings_Updater_Including_Alpha.Name = "cbSettings_Updater_Including_Alpha";
            this.cbSettings_Updater_Including_Alpha.Size = new System.Drawing.Size(159, 15);
            this.cbSettings_Updater_Including_Alpha.TabIndex = 3;
            this.cbSettings_Updater_Including_Alpha.Text = "Including Alpha-Versions";
            this.cbSettings_Updater_Including_Alpha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Updater_Including_Alpha.UseSelectable = true;
            this.cbSettings_Updater_Including_Alpha.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(3, 6);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(294, 23);
            this.metroLabel16.TabIndex = 2;
            this.metroLabel16.Text = "Updater\r\n\r\n";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.cbSettings_Themes);
            this.metroPanel4.Controls.Add(this.metroLabel15);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(309, 3);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(300, 124);
            this.metroPanel4.TabIndex = 4;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // cbSettings_Themes
            // 
            this.cbSettings_Themes.FormattingEnabled = true;
            this.cbSettings_Themes.ItemHeight = 23;
            this.cbSettings_Themes.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.cbSettings_Themes.Location = new System.Drawing.Point(3, 59);
            this.cbSettings_Themes.Name = "cbSettings_Themes";
            this.cbSettings_Themes.Size = new System.Drawing.Size(294, 29);
            this.cbSettings_Themes.TabIndex = 3;
            this.cbSettings_Themes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Themes.UseSelectable = true;
            this.cbSettings_Themes.SelectedIndexChanged += new System.EventHandler(this.cbSettings_Themes_SelectedIndexChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(3, 6);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(294, 23);
            this.metroLabel15.TabIndex = 2;
            this.metroLabel15.Text = "Theme for the launcher\r\n";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnSettings_ImportFromOriginalLauncher);
            this.metroPanel2.Controls.Add(this.metroLabel14);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(300, 124);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSettings_ImportFromOriginalLauncher
            // 
            this.btnSettings_ImportFromOriginalLauncher.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSettings_ImportFromOriginalLauncher.Location = new System.Drawing.Point(3, 38);
            this.btnSettings_ImportFromOriginalLauncher.Name = "btnSettings_ImportFromOriginalLauncher";
            this.btnSettings_ImportFromOriginalLauncher.Size = new System.Drawing.Size(294, 71);
            this.btnSettings_ImportFromOriginalLauncher.TabIndex = 3;
            this.btnSettings_ImportFromOriginalLauncher.Text = "Start import";
            this.btnSettings_ImportFromOriginalLauncher.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSettings_ImportFromOriginalLauncher.UseSelectable = true;
            this.btnSettings_ImportFromOriginalLauncher.Click += new System.EventHandler(this.btnSettings_ImportFromOriginalLauncher_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(3, 6);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(294, 23);
            this.metroLabel14.TabIndex = 2;
            this.metroLabel14.Text = "Import profiles from Minecraft Launcher";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.lblAbout_WindowsApiCodePack);
            this.tpAbout.Controls.Add(this.lblAbout_nUpdate);
            this.tpAbout.Controls.Add(this.lblAbout_IonicZip);
            this.tpAbout.Controls.Add(this.lblAbout_NewtonsoftJson);
            this.tpAbout.Controls.Add(this.lblAbout_ExceptionBase);
            this.tpAbout.Controls.Add(this.linkAbout_GitHub);
            this.tpAbout.Controls.Add(this.lblAbout_MetroFramework);
            this.tpAbout.Controls.Add(this.lblAbout);
            this.tpAbout.Controls.Add(this.rtbAbout_Licenses);
            this.tpAbout.Enabled = true;
            this.tpAbout.HorizontalScrollbarBarColor = true;
            this.tpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAbout.HorizontalScrollbarSize = 10;
            this.tpAbout.Location = new System.Drawing.Point(4, 38);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(930, 372);
            this.tpAbout.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpAbout.TabIndex = 5;
            this.tpAbout.Text = "About";
            this.tpAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpAbout.VerticalScrollbarBarColor = true;
            this.tpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tpAbout.VerticalScrollbarSize = 10;
            this.tpAbout.Visible = false;
            // 
            // lblAbout_WindowsApiCodePack
            // 
            this.lblAbout_WindowsApiCodePack.AutoSize = true;
            this.lblAbout_WindowsApiCodePack.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_WindowsApiCodePack.Location = new System.Drawing.Point(3, 165);
            this.lblAbout_WindowsApiCodePack.Name = "lblAbout_WindowsApiCodePack";
            this.lblAbout_WindowsApiCodePack.Size = new System.Drawing.Size(249, 19);
            this.lblAbout_WindowsApiCodePack.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_WindowsApiCodePack.TabIndex = 10;
            this.lblAbout_WindowsApiCodePack.Text = "WindowsAPICodePack by Microsoft";
            this.lblAbout_WindowsApiCodePack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_WindowsApiCodePack.WrapToLine = true;
            this.lblAbout_WindowsApiCodePack.Click += new System.EventHandler(this.lblAbout_WindowsApiCodePack_Click);
            // 
            // lblAbout_nUpdate
            // 
            this.lblAbout_nUpdate.AutoSize = true;
            this.lblAbout_nUpdate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_nUpdate.Location = new System.Drawing.Point(3, 146);
            this.lblAbout_nUpdate.Name = "lblAbout_nUpdate";
            this.lblAbout_nUpdate.Size = new System.Drawing.Size(190, 19);
            this.lblAbout_nUpdate.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_nUpdate.TabIndex = 9;
            this.lblAbout_nUpdate.Text = "nUpdate by Dominic Beger";
            this.lblAbout_nUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_nUpdate.WrapToLine = true;
            this.lblAbout_nUpdate.Click += new System.EventHandler(this.lblAbout_nUpdate_Click);
            // 
            // lblAbout_IonicZip
            // 
            this.lblAbout_IonicZip.AutoSize = true;
            this.lblAbout_IonicZip.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_IonicZip.Location = new System.Drawing.Point(3, 127);
            this.lblAbout_IonicZip.Name = "lblAbout_IonicZip";
            this.lblAbout_IonicZip.Size = new System.Drawing.Size(170, 19);
            this.lblAbout_IonicZip.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_IonicZip.TabIndex = 8;
            this.lblAbout_IonicZip.Text = "Ionic.Zip by Dino Chiesa";
            this.lblAbout_IonicZip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_IonicZip.WrapToLine = true;
            this.lblAbout_IonicZip.Click += new System.EventHandler(this.lblAbout_IonicZip_Click);
            // 
            // lblAbout_NewtonsoftJson
            // 
            this.lblAbout_NewtonsoftJson.AutoSize = true;
            this.lblAbout_NewtonsoftJson.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_NewtonsoftJson.Location = new System.Drawing.Point(3, 108);
            this.lblAbout_NewtonsoftJson.Name = "lblAbout_NewtonsoftJson";
            this.lblAbout_NewtonsoftJson.Size = new System.Drawing.Size(277, 19);
            this.lblAbout_NewtonsoftJson.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_NewtonsoftJson.TabIndex = 7;
            this.lblAbout_NewtonsoftJson.Text = "Newtonsoft.Json by James Newton-King";
            this.lblAbout_NewtonsoftJson.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_NewtonsoftJson.WrapToLine = true;
            this.lblAbout_NewtonsoftJson.Click += new System.EventHandler(this.lblAbout_NewtonsoftJson_Click);
            // 
            // lblAbout_ExceptionBase
            // 
            this.lblAbout_ExceptionBase.AutoSize = true;
            this.lblAbout_ExceptionBase.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_ExceptionBase.Location = new System.Drawing.Point(3, 89);
            this.lblAbout_ExceptionBase.Name = "lblAbout_ExceptionBase";
            this.lblAbout_ExceptionBase.Size = new System.Drawing.Size(242, 19);
            this.lblAbout_ExceptionBase.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_ExceptionBase.TabIndex = 6;
            this.lblAbout_ExceptionBase.Text = "ExceptionBase.NET by Leo Bernard";
            this.lblAbout_ExceptionBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_ExceptionBase.WrapToLine = true;
            this.lblAbout_ExceptionBase.Click += new System.EventHandler(this.lblAbout_ExceptionBase_Click);
            // 
            // linkAbout_GitHub
            // 
            this.linkAbout_GitHub.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.linkAbout_GitHub.Location = new System.Drawing.Point(3, 346);
            this.linkAbout_GitHub.Name = "linkAbout_GitHub";
            this.linkAbout_GitHub.Size = new System.Drawing.Size(341, 23);
            this.linkAbout_GitHub.TabIndex = 5;
            this.linkAbout_GitHub.Text = "MineLauncher on GitHub";
            this.linkAbout_GitHub.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkAbout_GitHub.UseSelectable = true;
            this.linkAbout_GitHub.Click += new System.EventHandler(this.linkAbout_GitHub_Click);
            // 
            // lblAbout_MetroFramework
            // 
            this.lblAbout_MetroFramework.AutoSize = true;
            this.lblAbout_MetroFramework.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_MetroFramework.Location = new System.Drawing.Point(3, 70);
            this.lblAbout_MetroFramework.Name = "lblAbout_MetroFramework";
            this.lblAbout_MetroFramework.Size = new System.Drawing.Size(231, 19);
            this.lblAbout_MetroFramework.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_MetroFramework.TabIndex = 4;
            this.lblAbout_MetroFramework.Text = "MetroFramework by Sven Walter";
            this.lblAbout_MetroFramework.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_MetroFramework.WrapToLine = true;
            this.lblAbout_MetroFramework.Click += new System.EventHandler(this.lblAbout_MetroFramework_Click);
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
            this.rtbAbout_Licenses.BackColor = System.Drawing.SystemColors.Window;
            this.rtbAbout_Licenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbout_Licenses.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbAbout_Licenses.DetectUrls = false;
            this.rtbAbout_Licenses.Location = new System.Drawing.Point(350, 3);
            this.rtbAbout_Licenses.Name = "rtbAbout_Licenses";
            this.rtbAbout_Licenses.ReadOnly = true;
            this.rtbAbout_Licenses.Size = new System.Drawing.Size(577, 366);
            this.rtbAbout_Licenses.TabIndex = 2;
            this.rtbAbout_Licenses.Text = resources.GetString("rtbAbout_Licenses.Text");
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
            this.pnlFastControl.Location = new System.Drawing.Point(30, 484);
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
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 595);
            this.Controls.Add(this.pnlFastControl);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(984, 595);
            this.MinimumSize = new System.Drawing.Size(984, 595);
            this.Name = "frmLauncher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MineLauncher";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLauncher_FormClosing);
            this.Shown += new System.EventHandler(this.frmLauncher_Shown);
            this.tcMain.ResumeLayout(false);
            this.tpStart.ResumeLayout(false);
            this.tpConsole.ResumeLayout(false);
            this.tpProfiles.ResumeLayout(false);
            this.pnlProfiles_Edit.ResumeLayout(false);
            this.pnlProfiles_Edit.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
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
        private MetroFramework.Controls.MetroButton btnProfile_Edit_SaveNew;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_JVM_Args;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_JVM_Path;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel pnlFastControl;
        private MetroFramework.Controls.MetroButton btnFastLogin_Login;
        private MetroFramework.Controls.MetroTextBox tbFastLogin_Password;
        private MetroFramework.Controls.MetroTextBox tbFastLogin_Username;
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
        private MetroFramework.Controls.MetroTabPage tpSettings;
        private MetroFramework.Controls.MetroTabPage tpAbout;
        private System.Windows.Forms.RichTextBox rtbAbout_Licenses;
        private MetroFramework.Controls.MetroLabel lblAbout;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_Offline;
        private MetroFramework.Controls.MetroLabel lblProfiles_Edit_Offline_PlayerName;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_Offline_PlayerName;
        private MetroFramework.Controls.MetroLabel lblAbout_MetroFramework;
        private MetroFramework.Controls.MetroProgressBar pbLog;
        private MetroFramework.Controls.MetroLabel lblLogPB;
        private MetroFramework.Controls.MetroButton btnProfile_Edit_Save;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnSettings_ImportFromOriginalLauncher;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroComboBox cbSettings_Themes;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLink linkAbout_GitHub;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroCheckBox cbSettings_Updater_Including_Beta;
        private MetroFramework.Controls.MetroCheckBox cbSettings_Updater_Including_Alpha;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblAbout_WindowsApiCodePack;
        private MetroFramework.Controls.MetroLabel lblAbout_nUpdate;
        private MetroFramework.Controls.MetroLabel lblAbout_IonicZip;
        private MetroFramework.Controls.MetroLabel lblAbout_NewtonsoftJson;
        private MetroFramework.Controls.MetroLabel lblAbout_ExceptionBase;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroCheckBox cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds;
        private MetroFramework.Controls.MetroCheckBox cbSettings_Launcher_ChangeGameIcon;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton btnProfiles_Edit_JVM_Path_Select;
        private MetroFramework.Controls.MetroButton btnProfiles_Edit_Directory_Select;
        private MetroFramework.Controls.MetroButton btnLaunch;
    }
}

