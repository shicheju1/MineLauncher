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
            this.tpFeatured = new MetroFramework.Controls.MetroTabPage();
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
            resources.ApplyResources(this.tcMain, "tcMain");
            this.tcMain.Controls.Add(this.tpStart);
            this.tcMain.Controls.Add(this.tpFeatured);
            this.tcMain.Controls.Add(this.tpConsole);
            this.tcMain.Controls.Add(this.tpProfiles);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Controls.Add(this.tpAbout);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Style = MetroFramework.MetroColorStyle.Blue;
            this.tcMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcMain.UseSelectable = true;
            // 
            // tpStart
            // 
            this.tpStart.Controls.Add(this.webBrowser1);
            this.tpStart.HorizontalScrollbarBarColor = true;
            this.tpStart.HorizontalScrollbarHighlightOnWheel = false;
            this.tpStart.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tpStart, "tpStart");
            this.tpStart.Name = "tpStart";
            this.tpStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpStart.VerticalScrollbarBarColor = true;
            this.tpStart.VerticalScrollbarHighlightOnWheel = false;
            this.tpStart.VerticalScrollbarSize = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            resources.ApplyResources(this.webBrowser1, "webBrowser1");
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Url = new System.Uri("http://mcupdate.tumblr.com/", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.lblLogPB);
            this.tpConsole.Controls.Add(this.pbLog);
            this.tpConsole.Controls.Add(this.rtbLog);
            this.tpConsole.HorizontalScrollbarBarColor = true;
            this.tpConsole.HorizontalScrollbarHighlightOnWheel = false;
            this.tpConsole.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tpConsole, "tpConsole");
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpConsole.VerticalScrollbarBarColor = true;
            this.tpConsole.VerticalScrollbarHighlightOnWheel = false;
            this.tpConsole.VerticalScrollbarSize = 10;
            // 
            // lblLogPB
            // 
            resources.ApplyResources(this.lblLogPB, "lblLogPB");
            this.lblLogPB.BackColor = System.Drawing.Color.Transparent;
            this.lblLogPB.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLogPB.Name = "lblLogPB";
            // 
            // pbLog
            // 
            resources.ApplyResources(this.pbLog, "pbLog");
            this.pbLog.HideProgressText = false;
            this.pbLog.Name = "pbLog";
            // 
            // rtbLog
            // 
            this.rtbLog.AcceptsTab = true;
            resources.ApplyResources(this.rtbLog, "rtbLog");
            this.rtbLog.BackColor = System.Drawing.SystemColors.Window;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbLog.DetectUrls = false;
            this.rtbLog.HideSelection = false;
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // tpProfiles
            // 
            this.tpProfiles.Controls.Add(this.pnlProfiles_Edit);
            this.tpProfiles.Controls.Add(this.cbProfiles_Select);
            this.tpProfiles.HorizontalScrollbarBarColor = true;
            this.tpProfiles.HorizontalScrollbarHighlightOnWheel = false;
            this.tpProfiles.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tpProfiles, "tpProfiles");
            this.tpProfiles.Name = "tpProfiles";
            this.tpProfiles.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpProfiles.VerticalScrollbarBarColor = true;
            this.tpProfiles.VerticalScrollbarHighlightOnWheel = false;
            this.tpProfiles.VerticalScrollbarSize = 10;
            // 
            // pnlProfiles_Edit
            // 
            resources.ApplyResources(this.pnlProfiles_Edit, "pnlProfiles_Edit");
            this.pnlProfiles_Edit.BackColor = System.Drawing.Color.Transparent;
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
            this.pnlProfiles_Edit.Name = "pnlProfiles_Edit";
            this.pnlProfiles_Edit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlProfiles_Edit.VerticalScrollbarBarColor = true;
            this.pnlProfiles_Edit.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfiles_Edit.VerticalScrollbarSize = 10;
            // 
            // btnProfiles_Edit_JVM_Path_Select
            // 
            this.btnProfiles_Edit_JVM_Path_Select.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.btnProfiles_Edit_JVM_Path_Select, "btnProfiles_Edit_JVM_Path_Select");
            this.btnProfiles_Edit_JVM_Path_Select.Name = "btnProfiles_Edit_JVM_Path_Select";
            this.btnProfiles_Edit_JVM_Path_Select.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfiles_Edit_JVM_Path_Select.UseSelectable = true;
            this.btnProfiles_Edit_JVM_Path_Select.Click += new System.EventHandler(this.btnProfiles_Edit_JVM_Path_Select_Click);
            // 
            // btnProfiles_Edit_Directory_Select
            // 
            this.btnProfiles_Edit_Directory_Select.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.btnProfiles_Edit_Directory_Select, "btnProfiles_Edit_Directory_Select");
            this.btnProfiles_Edit_Directory_Select.Name = "btnProfiles_Edit_Directory_Select";
            this.btnProfiles_Edit_Directory_Select.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfiles_Edit_Directory_Select.UseSelectable = true;
            this.btnProfiles_Edit_Directory_Select.Click += new System.EventHandler(this.btnProfiles_Edit_Directory_Select_Click);
            // 
            // btnProfile_Edit_Save
            // 
            resources.ApplyResources(this.btnProfile_Edit_Save, "btnProfile_Edit_Save");
            this.btnProfile_Edit_Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfile_Edit_Save.Name = "btnProfile_Edit_Save";
            this.btnProfile_Edit_Save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_Save.UseSelectable = true;
            this.btnProfile_Edit_Save.Click += new System.EventHandler(this.btnProfile_Edit_Save_Click);
            // 
            // lblProfiles_Edit_Offline_PlayerName
            // 
            resources.ApplyResources(this.lblProfiles_Edit_Offline_PlayerName, "lblProfiles_Edit_Offline_PlayerName");
            this.lblProfiles_Edit_Offline_PlayerName.Name = "lblProfiles_Edit_Offline_PlayerName";
            this.lblProfiles_Edit_Offline_PlayerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_Offline_PlayerName
            // 
            resources.ApplyResources(this.tbProfiles_Edit_Offline_PlayerName, "tbProfiles_Edit_Offline_PlayerName");
            this.tbProfiles_Edit_Offline_PlayerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_Offline_PlayerName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_Offline_PlayerName.Lines = new string[0];
            this.tbProfiles_Edit_Offline_PlayerName.MaxLength = 32767;
            this.tbProfiles_Edit_Offline_PlayerName.Name = "tbProfiles_Edit_Offline_PlayerName";
            this.tbProfiles_Edit_Offline_PlayerName.PasswordChar = '\0';
            this.tbProfiles_Edit_Offline_PlayerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_Offline_PlayerName.SelectedText = "";
            this.tbProfiles_Edit_Offline_PlayerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Offline_PlayerName.UseSelectable = true;
            // 
            // metroLabel12
            // 
            resources.ApplyResources(this.metroLabel12, "metroLabel12");
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_Offline
            // 
            resources.ApplyResources(this.toggleProfiles_Edit_Offline, "toggleProfiles_Edit_Offline");
            this.toggleProfiles_Edit_Offline.Checked = true;
            this.toggleProfiles_Edit_Offline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_Offline.DisplayStatus = false;
            this.toggleProfiles_Edit_Offline.Name = "toggleProfiles_Edit_Offline";
            this.toggleProfiles_Edit_Offline.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_Offline.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_Offline.UseSelectable = true;
            this.toggleProfiles_Edit_Offline.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_Offline_CheckedChanged);
            // 
            // metroLabel11
            // 
            resources.ApplyResources(this.metroLabel11, "metroLabel11");
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Custom
            // 
            resources.ApplyResources(this.toggleProfiles_Edit_ShowVersion_Custom, "toggleProfiles_Edit_ShowVersion_Custom");
            this.toggleProfiles_Edit_ShowVersion_Custom.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Custom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Custom.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Custom.Name = "toggleProfiles_Edit_ShowVersion_Custom";
            this.toggleProfiles_Edit_ShowVersion_Custom.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Custom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Custom.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Custom.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // btnProfile_Edit_Delete
            // 
            resources.ApplyResources(this.btnProfile_Edit_Delete, "btnProfile_Edit_Delete");
            this.btnProfile_Edit_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfile_Edit_Delete.Name = "btnProfile_Edit_Delete";
            this.btnProfile_Edit_Delete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_Delete.UseSelectable = true;
            this.btnProfile_Edit_Delete.Click += new System.EventHandler(this.btnProfile_Edit_Delete_Click);
            // 
            // metroLabel9
            // 
            resources.ApplyResources(this.metroLabel9, "metroLabel9");
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Alpha
            // 
            resources.ApplyResources(this.toggleProfiles_Edit_ShowVersion_Alpha, "toggleProfiles_Edit_ShowVersion_Alpha");
            this.toggleProfiles_Edit_ShowVersion_Alpha.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Alpha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Alpha.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Alpha.Name = "toggleProfiles_Edit_ShowVersion_Alpha";
            this.toggleProfiles_Edit_ShowVersion_Alpha.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Alpha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Alpha.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Alpha.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // metroLabel8
            // 
            resources.ApplyResources(this.metroLabel8, "metroLabel8");
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Beta
            // 
            resources.ApplyResources(this.toggleProfiles_Edit_ShowVersion_Beta, "toggleProfiles_Edit_ShowVersion_Beta");
            this.toggleProfiles_Edit_ShowVersion_Beta.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Beta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Beta.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Beta.Name = "toggleProfiles_Edit_ShowVersion_Beta";
            this.toggleProfiles_Edit_ShowVersion_Beta.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Beta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Beta.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Beta.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // metroLabel7
            // 
            resources.ApplyResources(this.metroLabel7, "metroLabel7");
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Snapshot
            // 
            resources.ApplyResources(this.toggleProfiles_Edit_ShowVersion_Snapshot, "toggleProfiles_Edit_ShowVersion_Snapshot");
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Name = "toggleProfiles_Edit_ShowVersion_Snapshot";
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Snapshot.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // metroLabel6
            // 
            resources.ApplyResources(this.metroLabel6, "metroLabel6");
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleProfiles_Edit_ShowVersion_Release
            // 
            resources.ApplyResources(this.toggleProfiles_Edit_ShowVersion_Release, "toggleProfiles_Edit_ShowVersion_Release");
            this.toggleProfiles_Edit_ShowVersion_Release.Checked = true;
            this.toggleProfiles_Edit_ShowVersion_Release.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleProfiles_Edit_ShowVersion_Release.DisplayStatus = false;
            this.toggleProfiles_Edit_ShowVersion_Release.Name = "toggleProfiles_Edit_ShowVersion_Release";
            this.toggleProfiles_Edit_ShowVersion_Release.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Release.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Release.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Release.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // btnProfile_Edit_SaveNew
            // 
            resources.ApplyResources(this.btnProfile_Edit_SaveNew, "btnProfile_Edit_SaveNew");
            this.btnProfile_Edit_SaveNew.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfile_Edit_SaveNew.Name = "btnProfile_Edit_SaveNew";
            this.btnProfile_Edit_SaveNew.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_SaveNew.UseMnemonic = false;
            this.btnProfile_Edit_SaveNew.UseSelectable = true;
            this.btnProfile_Edit_SaveNew.Click += new System.EventHandler(this.btnProfile_Edit_SaveNew_Click);
            // 
            // tbProfiles_Edit_JVM_Args
            // 
            resources.ApplyResources(this.tbProfiles_Edit_JVM_Args, "tbProfiles_Edit_JVM_Args");
            this.tbProfiles_Edit_JVM_Args.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_JVM_Args.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_JVM_Args.Lines = new string[0];
            this.tbProfiles_Edit_JVM_Args.MaxLength = 32767;
            this.tbProfiles_Edit_JVM_Args.Name = "tbProfiles_Edit_JVM_Args";
            this.tbProfiles_Edit_JVM_Args.PasswordChar = '\0';
            this.tbProfiles_Edit_JVM_Args.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_JVM_Args.SelectedText = "";
            this.tbProfiles_Edit_JVM_Args.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_JVM_Args.UseSelectable = true;
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_JVM_Path
            // 
            resources.ApplyResources(this.tbProfiles_Edit_JVM_Path, "tbProfiles_Edit_JVM_Path");
            this.tbProfiles_Edit_JVM_Path.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_JVM_Path.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_JVM_Path.Lines = new string[0];
            this.tbProfiles_Edit_JVM_Path.MaxLength = 32767;
            this.tbProfiles_Edit_JVM_Path.Name = "tbProfiles_Edit_JVM_Path";
            this.tbProfiles_Edit_JVM_Path.PasswordChar = '\0';
            this.tbProfiles_Edit_JVM_Path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_JVM_Path.SelectedText = "";
            this.tbProfiles_Edit_JVM_Path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_JVM_Path.UseSelectable = true;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_Directory
            // 
            resources.ApplyResources(this.tbProfiles_Edit_Directory, "tbProfiles_Edit_Directory");
            this.tbProfiles_Edit_Directory.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_Directory.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_Directory.Lines = new string[0];
            this.tbProfiles_Edit_Directory.MaxLength = 32767;
            this.tbProfiles_Edit_Directory.Name = "tbProfiles_Edit_Directory";
            this.tbProfiles_Edit_Directory.PasswordChar = '\0';
            this.tbProfiles_Edit_Directory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_Directory.SelectedText = "";
            this.tbProfiles_Edit_Directory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Directory.UseSelectable = true;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbProfiles_Edit_Name
            // 
            resources.ApplyResources(this.tbProfiles_Edit_Name, "tbProfiles_Edit_Name");
            this.tbProfiles_Edit_Name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_Name.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_Name.Lines = new string[0];
            this.tbProfiles_Edit_Name.MaxLength = 32767;
            this.tbProfiles_Edit_Name.Name = "tbProfiles_Edit_Name";
            this.tbProfiles_Edit_Name.PasswordChar = '\0';
            this.tbProfiles_Edit_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_Name.SelectedText = "";
            this.tbProfiles_Edit_Name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Name.UseSelectable = true;
            this.tbProfiles_Edit_Name.TextChanged += new System.EventHandler(this.tbProfiles_Edit_Name_TextChanged);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbProfiles_Edit_Version
            // 
            resources.ApplyResources(this.cbProfiles_Edit_Version, "cbProfiles_Edit_Version");
            this.cbProfiles_Edit_Version.DropDownHeight = 230;
            this.cbProfiles_Edit_Version.FormattingEnabled = true;
            this.cbProfiles_Edit_Version.Name = "cbProfiles_Edit_Version";
            this.cbProfiles_Edit_Version.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbProfiles_Edit_Version.UseSelectable = true;
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbProfiles_Select
            // 
            resources.ApplyResources(this.cbProfiles_Select, "cbProfiles_Select");
            this.cbProfiles_Select.DropDownHeight = 230;
            this.cbProfiles_Select.FormattingEnabled = true;
            this.cbProfiles_Select.Name = "cbProfiles_Select";
            this.cbProfiles_Select.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbProfiles_Select.UseSelectable = true;
            this.cbProfiles_Select.SelectedIndexChanged += new System.EventHandler(this.cbProfiles_Select_SelectedIndexChanged);
            // 
            // tpFeatured
            // 
            resources.ApplyResources(this.tpFeatured, "tpFeatured");
            this.tpFeatured.HorizontalScrollbar = true;
            this.tpFeatured.HorizontalScrollbarBarColor = true;
            this.tpFeatured.HorizontalScrollbarHighlightOnWheel = false;
            this.tpFeatured.HorizontalScrollbarSize = 10;
            this.tpFeatured.Name = "tpFeatured";
            this.tpFeatured.VerticalScrollbar = true;
            this.tpFeatured.VerticalScrollbarBarColor = true;
            this.tpFeatured.VerticalScrollbarHighlightOnWheel = true;
            this.tpFeatured.VerticalScrollbarSize = 10;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.metroPanel6);
            this.tpSettings.Controls.Add(this.metroPanel5);
            this.tpSettings.Controls.Add(this.metroPanel4);
            this.tpSettings.Controls.Add(this.metroPanel2);
            this.tpSettings.HorizontalScrollbarBarColor = true;
            this.tpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tpSettings.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tpSettings, "tpSettings");
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpSettings.VerticalScrollbarBarColor = true;
            this.tpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tpSettings.VerticalScrollbarSize = 10;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds);
            this.metroPanel6.Controls.Add(this.cbSettings_Launcher_ChangeGameIcon);
            this.metroPanel6.Controls.Add(this.metroLabel13);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel6, "metroPanel6");
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds
            // 
            resources.ApplyResources(this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds, "cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds");
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.Name = "cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds";
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.UseSelectable = true;
            this.cbSettings_Launcher_ChangeGameIcon_RandomEvery5Seconds.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // cbSettings_Launcher_ChangeGameIcon
            // 
            resources.ApplyResources(this.cbSettings_Launcher_ChangeGameIcon, "cbSettings_Launcher_ChangeGameIcon");
            this.cbSettings_Launcher_ChangeGameIcon.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Launcher_ChangeGameIcon.Name = "cbSettings_Launcher_ChangeGameIcon";
            this.cbSettings_Launcher_ChangeGameIcon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Launcher_ChangeGameIcon.UseSelectable = true;
            this.cbSettings_Launcher_ChangeGameIcon.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            resources.ApplyResources(this.metroLabel13, "metroLabel13");
            this.metroLabel13.Name = "metroLabel13";
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
            resources.ApplyResources(this.metroPanel5, "metroPanel5");
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // cbSettings_Updater_Including_Beta
            // 
            resources.ApplyResources(this.cbSettings_Updater_Including_Beta, "cbSettings_Updater_Including_Beta");
            this.cbSettings_Updater_Including_Beta.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Updater_Including_Beta.Name = "cbSettings_Updater_Including_Beta";
            this.cbSettings_Updater_Including_Beta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Updater_Including_Beta.UseSelectable = true;
            this.cbSettings_Updater_Including_Beta.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // cbSettings_Updater_Including_Alpha
            // 
            resources.ApplyResources(this.cbSettings_Updater_Including_Alpha, "cbSettings_Updater_Including_Alpha");
            this.cbSettings_Updater_Including_Alpha.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.cbSettings_Updater_Including_Alpha.Name = "cbSettings_Updater_Including_Alpha";
            this.cbSettings_Updater_Including_Alpha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Updater_Including_Alpha.UseSelectable = true;
            this.cbSettings_Updater_Including_Alpha.CheckedChanged += new System.EventHandler(this.cbSettings_CheckedChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            resources.ApplyResources(this.metroLabel16, "metroLabel16");
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.cbSettings_Themes);
            this.metroPanel4.Controls.Add(this.metroLabel15);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel4, "metroPanel4");
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // cbSettings_Themes
            // 
            this.cbSettings_Themes.FormattingEnabled = true;
            resources.ApplyResources(this.cbSettings_Themes, "cbSettings_Themes");
            this.cbSettings_Themes.Items.AddRange(new object[] {
            resources.GetString("cbSettings_Themes.Items"),
            resources.GetString("cbSettings_Themes.Items1")});
            this.cbSettings_Themes.Name = "cbSettings_Themes";
            this.cbSettings_Themes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbSettings_Themes.UseSelectable = true;
            this.cbSettings_Themes.SelectedIndexChanged += new System.EventHandler(this.cbSettings_Themes_SelectedIndexChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            resources.ApplyResources(this.metroLabel15, "metroLabel15");
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnSettings_ImportFromOriginalLauncher);
            this.metroPanel2.Controls.Add(this.metroLabel14);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.metroPanel2, "metroPanel2");
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnSettings_ImportFromOriginalLauncher
            // 
            this.btnSettings_ImportFromOriginalLauncher.FontSize = MetroFramework.MetroButtonSize.Tall;
            resources.ApplyResources(this.btnSettings_ImportFromOriginalLauncher, "btnSettings_ImportFromOriginalLauncher");
            this.btnSettings_ImportFromOriginalLauncher.Name = "btnSettings_ImportFromOriginalLauncher";
            this.btnSettings_ImportFromOriginalLauncher.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSettings_ImportFromOriginalLauncher.UseSelectable = true;
            this.btnSettings_ImportFromOriginalLauncher.Click += new System.EventHandler(this.btnSettings_ImportFromOriginalLauncher_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            resources.ApplyResources(this.metroLabel14, "metroLabel14");
            this.metroLabel14.Name = "metroLabel14";
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
            this.tpAbout.HorizontalScrollbarBarColor = true;
            this.tpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAbout.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tpAbout, "tpAbout");
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Style = MetroFramework.MetroColorStyle.Blue;
            this.tpAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tpAbout.VerticalScrollbarBarColor = true;
            this.tpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tpAbout.VerticalScrollbarSize = 10;
            // 
            // lblAbout_WindowsApiCodePack
            // 
            resources.ApplyResources(this.lblAbout_WindowsApiCodePack, "lblAbout_WindowsApiCodePack");
            this.lblAbout_WindowsApiCodePack.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_WindowsApiCodePack.Name = "lblAbout_WindowsApiCodePack";
            this.lblAbout_WindowsApiCodePack.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_WindowsApiCodePack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_WindowsApiCodePack.WrapToLine = true;
            this.lblAbout_WindowsApiCodePack.Click += new System.EventHandler(this.lblAbout_WindowsApiCodePack_Click);
            // 
            // lblAbout_nUpdate
            // 
            resources.ApplyResources(this.lblAbout_nUpdate, "lblAbout_nUpdate");
            this.lblAbout_nUpdate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_nUpdate.Name = "lblAbout_nUpdate";
            this.lblAbout_nUpdate.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_nUpdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_nUpdate.WrapToLine = true;
            this.lblAbout_nUpdate.Click += new System.EventHandler(this.lblAbout_nUpdate_Click);
            // 
            // lblAbout_IonicZip
            // 
            resources.ApplyResources(this.lblAbout_IonicZip, "lblAbout_IonicZip");
            this.lblAbout_IonicZip.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_IonicZip.Name = "lblAbout_IonicZip";
            this.lblAbout_IonicZip.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_IonicZip.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_IonicZip.WrapToLine = true;
            this.lblAbout_IonicZip.Click += new System.EventHandler(this.lblAbout_IonicZip_Click);
            // 
            // lblAbout_NewtonsoftJson
            // 
            resources.ApplyResources(this.lblAbout_NewtonsoftJson, "lblAbout_NewtonsoftJson");
            this.lblAbout_NewtonsoftJson.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_NewtonsoftJson.Name = "lblAbout_NewtonsoftJson";
            this.lblAbout_NewtonsoftJson.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_NewtonsoftJson.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_NewtonsoftJson.WrapToLine = true;
            this.lblAbout_NewtonsoftJson.Click += new System.EventHandler(this.lblAbout_NewtonsoftJson_Click);
            // 
            // lblAbout_ExceptionBase
            // 
            resources.ApplyResources(this.lblAbout_ExceptionBase, "lblAbout_ExceptionBase");
            this.lblAbout_ExceptionBase.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_ExceptionBase.Name = "lblAbout_ExceptionBase";
            this.lblAbout_ExceptionBase.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_ExceptionBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_ExceptionBase.WrapToLine = true;
            this.lblAbout_ExceptionBase.Click += new System.EventHandler(this.lblAbout_ExceptionBase_Click);
            // 
            // linkAbout_GitHub
            // 
            this.linkAbout_GitHub.FontSize = MetroFramework.MetroLinkSize.Medium;
            resources.ApplyResources(this.linkAbout_GitHub, "linkAbout_GitHub");
            this.linkAbout_GitHub.Name = "linkAbout_GitHub";
            this.linkAbout_GitHub.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.linkAbout_GitHub.UseSelectable = true;
            this.linkAbout_GitHub.Click += new System.EventHandler(this.linkAbout_GitHub_Click);
            // 
            // lblAbout_MetroFramework
            // 
            resources.ApplyResources(this.lblAbout_MetroFramework, "lblAbout_MetroFramework");
            this.lblAbout_MetroFramework.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAbout_MetroFramework.Name = "lblAbout_MetroFramework";
            this.lblAbout_MetroFramework.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout_MetroFramework.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout_MetroFramework.WrapToLine = true;
            this.lblAbout_MetroFramework.Click += new System.EventHandler(this.lblAbout_MetroFramework_Click);
            // 
            // lblAbout
            // 
            resources.ApplyResources(this.lblAbout, "lblAbout");
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Style = MetroFramework.MetroColorStyle.White;
            this.lblAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAbout.WrapToLine = true;
            // 
            // rtbAbout_Licenses
            // 
            resources.ApplyResources(this.rtbAbout_Licenses, "rtbAbout_Licenses");
            this.rtbAbout_Licenses.BackColor = System.Drawing.SystemColors.Window;
            this.rtbAbout_Licenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAbout_Licenses.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbAbout_Licenses.DetectUrls = false;
            this.rtbAbout_Licenses.Name = "rtbAbout_Licenses";
            this.rtbAbout_Licenses.ReadOnly = true;
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
            resources.ApplyResources(this.pnlFastControl, "pnlFastControl");
            this.pnlFastControl.Name = "pnlFastControl";
            this.pnlFastControl.VerticalScrollbarBarColor = true;
            this.pnlFastControl.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFastControl.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cbFastControl_SelectProfile);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            resources.ApplyResources(this.metroPanel1, "metroPanel1");
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cbFastControl_SelectProfile
            // 
            resources.ApplyResources(this.cbFastControl_SelectProfile, "cbFastControl_SelectProfile");
            this.cbFastControl_SelectProfile.FormattingEnabled = true;
            this.cbFastControl_SelectProfile.Name = "cbFastControl_SelectProfile";
            this.cbFastControl_SelectProfile.UseSelectable = true;
            this.cbFastControl_SelectProfile.SelectedIndexChanged += new System.EventHandler(this.cbFastControl_SelectProfile_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            resources.ApplyResources(this.metroLabel10, "metroLabel10");
            this.metroLabel10.Name = "metroLabel10";
            // 
            // pnlFastInfo
            // 
            resources.ApplyResources(this.pnlFastInfo, "pnlFastInfo");
            this.pnlFastInfo.Controls.Add(this.lblFastInfo_Welcome);
            this.pnlFastInfo.Controls.Add(this.metroPanel3);
            this.pnlFastInfo.HorizontalScrollbarBarColor = true;
            this.pnlFastInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFastInfo.HorizontalScrollbarSize = 10;
            this.pnlFastInfo.Name = "pnlFastInfo";
            this.pnlFastInfo.VerticalScrollbarBarColor = true;
            this.pnlFastInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFastInfo.VerticalScrollbarSize = 10;
            // 
            // lblFastInfo_Welcome
            // 
            resources.ApplyResources(this.lblFastInfo_Welcome, "lblFastInfo_Welcome");
            this.lblFastInfo_Welcome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFastInfo_Welcome.Name = "lblFastInfo_Welcome";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.pbFastInfo_Avatar);
            resources.ApplyResources(this.metroPanel3, "metroPanel3");
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // pbFastInfo_Avatar
            // 
            resources.ApplyResources(this.pbFastInfo_Avatar, "pbFastInfo_Avatar");
            this.pbFastInfo_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pbFastInfo_Avatar.Name = "pbFastInfo_Avatar";
            this.pbFastInfo_Avatar.TabStop = false;
            // 
            // pnlFastLogin
            // 
            resources.ApplyResources(this.pnlFastLogin, "pnlFastLogin");
            this.pnlFastLogin.Controls.Add(this.tbFastLogin_Password);
            this.pnlFastLogin.Controls.Add(this.btnFastLogin_Login);
            this.pnlFastLogin.Controls.Add(this.tbFastLogin_Username);
            this.pnlFastLogin.HorizontalScrollbarBarColor = true;
            this.pnlFastLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlFastLogin.HorizontalScrollbarSize = 10;
            this.pnlFastLogin.Name = "pnlFastLogin";
            this.pnlFastLogin.VerticalScrollbarBarColor = true;
            this.pnlFastLogin.VerticalScrollbarHighlightOnWheel = false;
            this.pnlFastLogin.VerticalScrollbarSize = 10;
            // 
            // tbFastLogin_Password
            // 
            this.tbFastLogin_Password.Lines = new string[0];
            resources.ApplyResources(this.tbFastLogin_Password, "tbFastLogin_Password");
            this.tbFastLogin_Password.MaxLength = 32767;
            this.tbFastLogin_Password.Name = "tbFastLogin_Password";
            this.tbFastLogin_Password.PasswordChar = '●';
            this.tbFastLogin_Password.PromptText = "Password";
            this.tbFastLogin_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFastLogin_Password.SelectedText = "";
            this.tbFastLogin_Password.UseSelectable = true;
            this.tbFastLogin_Password.UseSystemPasswordChar = true;
            // 
            // btnFastLogin_Login
            // 
            resources.ApplyResources(this.btnFastLogin_Login, "btnFastLogin_Login");
            this.btnFastLogin_Login.Name = "btnFastLogin_Login";
            this.btnFastLogin_Login.UseSelectable = true;
            this.btnFastLogin_Login.Click += new System.EventHandler(this.btnFastLogin_Login_Click);
            // 
            // tbFastLogin_Username
            // 
            this.tbFastLogin_Username.Lines = new string[0];
            resources.ApplyResources(this.tbFastLogin_Username, "tbFastLogin_Username");
            this.tbFastLogin_Username.MaxLength = 32767;
            this.tbFastLogin_Username.Name = "tbFastLogin_Username";
            this.tbFastLogin_Username.PasswordChar = '\0';
            this.tbFastLogin_Username.PromptText = "Username";
            this.tbFastLogin_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFastLogin_Username.SelectedText = "";
            this.tbFastLogin_Username.UseSelectable = true;
            // 
            // btnLaunch
            // 
            resources.ApplyResources(this.btnLaunch, "btnLaunch");
            this.btnLaunch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.UseSelectable = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // frmLauncher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFastControl);
            this.Controls.Add(this.tcMain);
            this.MaximizeBox = false;
            this.Name = "frmLauncher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
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
        private MetroFramework.Controls.MetroTabPage tpFeatured;
    }
}

