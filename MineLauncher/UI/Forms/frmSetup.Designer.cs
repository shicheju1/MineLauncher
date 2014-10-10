namespace MineLauncher.UI.Forms
{
    partial class frmSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.tcMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tileWelcome_Next = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tileTheme_Last = new MetroFramework.Controls.MetroTile();
            this.tileTheme_Next = new MetroFramework.Controls.MetroTile();
            this.cbTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.toggleLogin_UseOfflineMode = new MetroFramework.Controls.MetroToggle();
            this.tileLogin_Last = new MetroFramework.Controls.MetroTile();
            this.tileLogin_Next = new MetroFramework.Controls.MetroTile();
            this.btnLogin_DoLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbLogin_Password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbLogin_Username = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.tileProfile_Last = new MetroFramework.Controls.MetroTile();
            this.tileProfile_Next = new MetroFramework.Controls.MetroTile();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.pnlProfiles_Edit = new MetroFramework.Controls.MetroPanel();
            this.btnProfiles_ImportFromOriginalLauncher = new MetroFramework.Controls.MetroButton();
            this.lblProfiles_Edit_Offline_PlayerName = new MetroFramework.Controls.MetroLabel();
            this.tbProfiles_Edit_Offline_PlayerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Custom = new MetroFramework.Controls.MetroToggle();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Alpha = new MetroFramework.Controls.MetroToggle();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Beta = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Snapshot = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.toggleProfiles_Edit_ShowVersion_Release = new MetroFramework.Controls.MetroToggle();
            this.btnProfile_Edit_Save = new MetroFramework.Controls.MetroButton();
            this.tbProfiles_Edit_Directory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tbProfiles_Edit_Name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.cbProfiles_Edit_Version = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tileStartLauncher = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tcMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.pnlProfiles_Edit.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.metroTabPage1);
            this.tcMain.Controls.Add(this.metroTabPage2);
            this.tcMain.Controls.Add(this.metroTabPage3);
            this.tcMain.Controls.Add(this.metroTabPage4);
            this.tcMain.Controls.Add(this.metroTabPage5);
            this.tcMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcMain.ItemSize = new System.Drawing.Size(68, 37);
            this.tcMain.Location = new System.Drawing.Point(23, 63);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 3;
            this.tcMain.Size = new System.Drawing.Size(884, 420);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcMain.TabIndex = 0;
            this.tcMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tcMain.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.tileWelcome_Next);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(876, 375);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Welcome";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel12.Location = new System.Drawing.Point(5, 342);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(246, 30);
            this.metroLabel12.TabIndex = 7;
            this.metroLabel12.Text = "If you continue, you accept the following license: \r\nhttp://stor.lukasberger.at/l" +
    "icense-en.txt";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tileWelcome_Next
            // 
            this.tileWelcome_Next.ActiveControl = null;
            this.tileWelcome_Next.Location = new System.Drawing.Point(768, 342);
            this.tileWelcome_Next.Name = "tileWelcome_Next";
            this.tileWelcome_Next.Size = new System.Drawing.Size(105, 30);
            this.tileWelcome_Next.TabIndex = 6;
            this.tileWelcome_Next.Text = "Next step";
            this.tileWelcome_Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileWelcome_Next.UseSelectable = true;
            this.tileWelcome_Next.Click += new System.EventHandler(this.tileWelcome_Next_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(5, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(865, 334);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.WrapToLine = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.tileTheme_Last);
            this.metroTabPage2.Controls.Add(this.tileTheme_Next);
            this.metroTabPage2.Controls.Add(this.cbTheme);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(876, 375);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Launcher theme";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tileTheme_Last
            // 
            this.tileTheme_Last.ActiveControl = null;
            this.tileTheme_Last.Location = new System.Drawing.Point(3, 342);
            this.tileTheme_Last.Name = "tileTheme_Last";
            this.tileTheme_Last.Size = new System.Drawing.Size(105, 30);
            this.tileTheme_Last.TabIndex = 6;
            this.tileTheme_Last.Text = "Last step";
            this.tileTheme_Last.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tileTheme_Last.UseSelectable = true;
            this.tileTheme_Last.Click += new System.EventHandler(this.tileTheme_Last_Click);
            // 
            // tileTheme_Next
            // 
            this.tileTheme_Next.ActiveControl = null;
            this.tileTheme_Next.Location = new System.Drawing.Point(768, 342);
            this.tileTheme_Next.Name = "tileTheme_Next";
            this.tileTheme_Next.Size = new System.Drawing.Size(105, 30);
            this.tileTheme_Next.TabIndex = 5;
            this.tileTheme_Next.Text = "Next step";
            this.tileTheme_Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileTheme_Next.UseSelectable = true;
            this.tileTheme_Next.Click += new System.EventHandler(this.tileTheme_Next_Click);
            // 
            // cbTheme
            // 
            this.cbTheme.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbTheme.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.ItemHeight = 29;
            this.cbTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.cbTheme.Location = new System.Drawing.Point(288, 193);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(300, 35);
            this.cbTheme.TabIndex = 4;
            this.cbTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbTheme.UseSelectable = true;
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(5, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(866, 182);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Select a theme you like";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.WrapToLine = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.toggleLogin_UseOfflineMode);
            this.metroTabPage3.Controls.Add(this.tileLogin_Last);
            this.metroTabPage3.Controls.Add(this.tileLogin_Next);
            this.metroTabPage3.Controls.Add(this.btnLogin_DoLogin);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.tbLogin_Password);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.tbLogin_Username);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(876, 375);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "First Login";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(679, 168);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(138, 17);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Play in offline-mode";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // toggleLogin_UseOfflineMode
            // 
            this.toggleLogin_UseOfflineMode.AutoSize = true;
            this.toggleLogin_UseOfflineMode.DisplayStatus = false;
            this.toggleLogin_UseOfflineMode.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.toggleLogin_UseOfflineMode.Location = new System.Drawing.Point(823, 168);
            this.toggleLogin_UseOfflineMode.Name = "toggleLogin_UseOfflineMode";
            this.toggleLogin_UseOfflineMode.Size = new System.Drawing.Size(50, 17);
            this.toggleLogin_UseOfflineMode.TabIndex = 9;
            this.toggleLogin_UseOfflineMode.Text = "Aus";
            this.toggleLogin_UseOfflineMode.UseSelectable = true;
            this.toggleLogin_UseOfflineMode.CheckedChanged += new System.EventHandler(this.toggleLogin_UseOfflineMode_CheckedChanged);
            // 
            // tileLogin_Last
            // 
            this.tileLogin_Last.ActiveControl = null;
            this.tileLogin_Last.Location = new System.Drawing.Point(3, 342);
            this.tileLogin_Last.Name = "tileLogin_Last";
            this.tileLogin_Last.Size = new System.Drawing.Size(105, 30);
            this.tileLogin_Last.TabIndex = 8;
            this.tileLogin_Last.Text = "Last step";
            this.tileLogin_Last.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tileLogin_Last.UseSelectable = true;
            this.tileLogin_Last.Click += new System.EventHandler(this.tileLogin_Last_Click);
            // 
            // tileLogin_Next
            // 
            this.tileLogin_Next.ActiveControl = null;
            this.tileLogin_Next.Enabled = false;
            this.tileLogin_Next.Location = new System.Drawing.Point(768, 342);
            this.tileLogin_Next.Name = "tileLogin_Next";
            this.tileLogin_Next.Size = new System.Drawing.Size(105, 30);
            this.tileLogin_Next.TabIndex = 7;
            this.tileLogin_Next.Text = "Next step";
            this.tileLogin_Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileLogin_Next.UseSelectable = true;
            this.tileLogin_Next.Click += new System.EventHandler(this.tileLogin_Next_Click);
            // 
            // btnLogin_DoLogin
            // 
            this.btnLogin_DoLogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnLogin_DoLogin.Location = new System.Drawing.Point(185, 122);
            this.btnLogin_DoLogin.Name = "btnLogin_DoLogin";
            this.btnLogin_DoLogin.Size = new System.Drawing.Size(688, 38);
            this.btnLogin_DoLogin.TabIndex = 6;
            this.btnLogin_DoLogin.Text = "Let\'s try it!";
            this.btnLogin_DoLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin_DoLogin.UseSelectable = true;
            this.btnLogin_DoLogin.Click += new System.EventHandler(this.btnLogin_DoLogin_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 84);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(176, 32);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Password";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbLogin_Password
            // 
            this.tbLogin_Password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbLogin_Password.Lines = new string[0];
            this.tbLogin_Password.Location = new System.Drawing.Point(185, 84);
            this.tbLogin_Password.MaxLength = 32767;
            this.tbLogin_Password.Name = "tbLogin_Password";
            this.tbLogin_Password.PasswordChar = '●';
            this.tbLogin_Password.PromptText = "MinePassword";
            this.tbLogin_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogin_Password.SelectedText = "";
            this.tbLogin_Password.Size = new System.Drawing.Size(688, 32);
            this.tbLogin_Password.TabIndex = 4;
            this.tbLogin_Password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbLogin_Password.UseSelectable = true;
            this.tbLogin_Password.UseSystemPasswordChar = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(176, 32);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Username";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbLogin_Username
            // 
            this.tbLogin_Username.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbLogin_Username.Lines = new string[0];
            this.tbLogin_Username.Location = new System.Drawing.Point(185, 46);
            this.tbLogin_Username.MaxLength = 32767;
            this.tbLogin_Username.Name = "tbLogin_Username";
            this.tbLogin_Username.PasswordChar = '\0';
            this.tbLogin_Username.PromptText = "example@johndoe.com";
            this.tbLogin_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLogin_Username.SelectedText = "";
            this.tbLogin_Username.Size = new System.Drawing.Size(688, 32);
            this.tbLogin_Username.TabIndex = 2;
            this.tbLogin_Username.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbLogin_Username.UseSelectable = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.tileProfile_Last);
            this.metroTabPage4.Controls.Add(this.tileProfile_Next);
            this.metroTabPage4.Controls.Add(this.metroLabel16);
            this.metroTabPage4.Controls.Add(this.pnlProfiles_Edit);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(876, 375);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "First Profile";
            this.metroTabPage4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // tileProfile_Last
            // 
            this.tileProfile_Last.ActiveControl = null;
            this.tileProfile_Last.Location = new System.Drawing.Point(4, 342);
            this.tileProfile_Last.Name = "tileProfile_Last";
            this.tileProfile_Last.Size = new System.Drawing.Size(105, 30);
            this.tileProfile_Last.TabIndex = 10;
            this.tileProfile_Last.Text = "Last step";
            this.tileProfile_Last.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tileProfile_Last.UseSelectable = true;
            this.tileProfile_Last.Click += new System.EventHandler(this.tileProfile_Last_Click);
            // 
            // tileProfile_Next
            // 
            this.tileProfile_Next.ActiveControl = null;
            this.tileProfile_Next.Enabled = false;
            this.tileProfile_Next.Location = new System.Drawing.Point(768, 342);
            this.tileProfile_Next.Name = "tileProfile_Next";
            this.tileProfile_Next.Size = new System.Drawing.Size(105, 30);
            this.tileProfile_Next.TabIndex = 9;
            this.tileProfile_Next.Text = "Next step";
            this.tileProfile_Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileProfile_Next.UseSelectable = true;
            this.tileProfile_Next.Click += new System.EventHandler(this.tileProfile_Next_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(4, 8);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(866, 77);
            this.metroLabel16.TabIndex = 5;
            this.metroLabel16.Text = "And now create your first profile.\r\nYou can select every Minecraft version you wa" +
    "nt, but the newest version is recommended";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel16.WrapToLine = true;
            // 
            // pnlProfiles_Edit
            // 
            this.pnlProfiles_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfiles_Edit.Controls.Add(this.btnProfiles_ImportFromOriginalLauncher);
            this.pnlProfiles_Edit.Controls.Add(this.lblProfiles_Edit_Offline_PlayerName);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_Offline_PlayerName);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel11);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Custom);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel9);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Alpha);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel8);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Beta);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel7);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Snapshot);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel6);
            this.pnlProfiles_Edit.Controls.Add(this.toggleProfiles_Edit_ShowVersion_Release);
            this.pnlProfiles_Edit.Controls.Add(this.btnProfile_Edit_Save);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_Directory);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel13);
            this.pnlProfiles_Edit.Controls.Add(this.tbProfiles_Edit_Name);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel14);
            this.pnlProfiles_Edit.Controls.Add(this.cbProfiles_Edit_Version);
            this.pnlProfiles_Edit.Controls.Add(this.metroLabel15);
            this.pnlProfiles_Edit.HorizontalScrollbarBarColor = true;
            this.pnlProfiles_Edit.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProfiles_Edit.HorizontalScrollbarSize = 10;
            this.pnlProfiles_Edit.Location = new System.Drawing.Point(0, 88);
            this.pnlProfiles_Edit.Name = "pnlProfiles_Edit";
            this.pnlProfiles_Edit.Size = new System.Drawing.Size(873, 248);
            this.pnlProfiles_Edit.TabIndex = 4;
            this.pnlProfiles_Edit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlProfiles_Edit.VerticalScrollbarBarColor = true;
            this.pnlProfiles_Edit.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProfiles_Edit.VerticalScrollbarSize = 10;
            // 
            // btnProfiles_ImportFromOriginalLauncher
            // 
            this.btnProfiles_ImportFromOriginalLauncher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfiles_ImportFromOriginalLauncher.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnProfiles_ImportFromOriginalLauncher.Location = new System.Drawing.Point(13, 198);
            this.btnProfiles_ImportFromOriginalLauncher.Name = "btnProfiles_ImportFromOriginalLauncher";
            this.btnProfiles_ImportFromOriginalLauncher.Size = new System.Drawing.Size(257, 42);
            this.btnProfiles_ImportFromOriginalLauncher.TabIndex = 32;
            this.btnProfiles_ImportFromOriginalLauncher.Text = "Import from Original Launcher";
            this.btnProfiles_ImportFromOriginalLauncher.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfiles_ImportFromOriginalLauncher.UseSelectable = true;
            this.btnProfiles_ImportFromOriginalLauncher.Click += new System.EventHandler(this.btnProfiles_ImportFromOriginalLauncher_Click);
            // 
            // lblProfiles_Edit_Offline_PlayerName
            // 
            this.lblProfiles_Edit_Offline_PlayerName.AutoSize = true;
            this.lblProfiles_Edit_Offline_PlayerName.Location = new System.Drawing.Point(474, 171);
            this.lblProfiles_Edit_Offline_PlayerName.Name = "lblProfiles_Edit_Offline_PlayerName";
            this.lblProfiles_Edit_Offline_PlayerName.Size = new System.Drawing.Size(165, 19);
            this.lblProfiles_Edit_Offline_PlayerName.TabIndex = 31;
            this.lblProfiles_Edit_Offline_PlayerName.Text = "Offline-Mode playername:";
            this.lblProfiles_Edit_Offline_PlayerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblProfiles_Edit_Offline_PlayerName.Visible = false;
            // 
            // tbProfiles_Edit_Offline_PlayerName
            // 
            this.tbProfiles_Edit_Offline_PlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProfiles_Edit_Offline_PlayerName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbProfiles_Edit_Offline_PlayerName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbProfiles_Edit_Offline_PlayerName.Lines = new string[0];
            this.tbProfiles_Edit_Offline_PlayerName.Location = new System.Drawing.Point(645, 168);
            this.tbProfiles_Edit_Offline_PlayerName.MaxLength = 32767;
            this.tbProfiles_Edit_Offline_PlayerName.Name = "tbProfiles_Edit_Offline_PlayerName";
            this.tbProfiles_Edit_Offline_PlayerName.PasswordChar = '\0';
            this.tbProfiles_Edit_Offline_PlayerName.PromptText = "Notch";
            this.tbProfiles_Edit_Offline_PlayerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfiles_Edit_Offline_PlayerName.SelectedText = "";
            this.tbProfiles_Edit_Offline_PlayerName.Size = new System.Drawing.Size(220, 24);
            this.tbProfiles_Edit_Offline_PlayerName.TabIndex = 30;
            this.tbProfiles_Edit_Offline_PlayerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Offline_PlayerName.UseSelectable = true;
            this.tbProfiles_Edit_Offline_PlayerName.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(693, 41);
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
            this.toggleProfiles_Edit_ShowVersion_Custom.Location = new System.Drawing.Point(794, 43);
            this.toggleProfiles_Edit_ShowVersion_Custom.Name = "toggleProfiles_Edit_ShowVersion_Custom";
            this.toggleProfiles_Edit_ShowVersion_Custom.Size = new System.Drawing.Size(50, 17);
            this.toggleProfiles_Edit_ShowVersion_Custom.Style = MetroFramework.MetroColorStyle.Blue;
            this.toggleProfiles_Edit_ShowVersion_Custom.TabIndex = 24;
            this.toggleProfiles_Edit_ShowVersion_Custom.Text = "An";
            this.toggleProfiles_Edit_ShowVersion_Custom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toggleProfiles_Edit_ShowVersion_Custom.UseSelectable = true;
            this.toggleProfiles_Edit_ShowVersion_Custom.CheckedChanged += new System.EventHandler(this.toggleProfiles_Edit_ShowVersion_CheckedChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(537, 41);
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
            this.toggleProfiles_Edit_ShowVersion_Alpha.Location = new System.Drawing.Point(627, 43);
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
            this.metroLabel8.Location = new System.Drawing.Point(389, 41);
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
            this.toggleProfiles_Edit_ShowVersion_Beta.Location = new System.Drawing.Point(471, 43);
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
            this.metroLabel7.Location = new System.Drawing.Point(209, 41);
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
            this.toggleProfiles_Edit_ShowVersion_Snapshot.Location = new System.Drawing.Point(323, 43);
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
            this.metroLabel6.Location = new System.Drawing.Point(44, 41);
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
            this.toggleProfiles_Edit_ShowVersion_Release.Location = new System.Drawing.Point(143, 43);
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
            this.btnProfile_Edit_Save.Location = new System.Drawing.Point(645, 198);
            this.btnProfile_Edit_Save.Name = "btnProfile_Edit_Save";
            this.btnProfile_Edit_Save.Size = new System.Drawing.Size(220, 42);
            this.btnProfile_Edit_Save.TabIndex = 13;
            this.btnProfile_Edit_Save.Text = "Save profile";
            this.btnProfile_Edit_Save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnProfile_Edit_Save.UseSelectable = true;
            this.btnProfile_Edit_Save.Click += new System.EventHandler(this.btnProfile_Edit_Save_Click);
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
            this.tbProfiles_Edit_Directory.Size = new System.Drawing.Size(746, 24);
            this.tbProfiles_Edit_Directory.TabIndex = 8;
            this.tbProfiles_Edit_Directory.Text = "C:\\Minecraft\\My Profile";
            this.tbProfiles_Edit_Directory.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Directory.UseSelectable = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(13, 116);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(101, 19);
            this.metroLabel13.TabIndex = 7;
            this.metroLabel13.Text = "Game directory";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.tbProfiles_Edit_Name.Size = new System.Drawing.Size(746, 24);
            this.tbProfiles_Edit_Name.TabIndex = 6;
            this.tbProfiles_Edit_Name.Text = "My Profile";
            this.tbProfiles_Edit_Name.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbProfiles_Edit_Name.UseSelectable = true;
            this.tbProfiles_Edit_Name.TextChanged += new System.EventHandler(this.tbProfiles_Edit_Name_TextChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(29, 83);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(84, 19);
            this.metroLabel14.TabIndex = 5;
            this.metroLabel14.Text = "Profile name";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.cbProfiles_Edit_Version.Size = new System.Drawing.Size(746, 29);
            this.cbProfiles_Edit_Version.TabIndex = 4;
            this.cbProfiles_Edit_Version.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbProfiles_Edit_Version.UseSelectable = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(3, 13);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(110, 19);
            this.metroLabel15.TabIndex = 2;
            this.metroLabel15.Text = "Minecraft Version";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.metroLabel10);
            this.metroTabPage5.Controls.Add(this.tileStartLauncher);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(876, 375);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Finished";
            this.metroTabPage5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(3, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(870, 299);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "You have finished the setup!\r\n\r\nNow you can create more profiles and change your " +
    "minecraft account.\r\nIf you play offline-mode, you can enter a playername in the " +
    "launcher.";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.WrapToLine = true;
            // 
            // tileStartLauncher
            // 
            this.tileStartLauncher.ActiveControl = null;
            this.tileStartLauncher.Location = new System.Drawing.Point(219, 302);
            this.tileStartLauncher.Name = "tileStartLauncher";
            this.tileStartLauncher.PaintTileCount = false;
            this.tileStartLauncher.Size = new System.Drawing.Size(438, 70);
            this.tileStartLauncher.TabIndex = 2;
            this.tileStartLauncher.Text = "Save settings && launch the Launcher";
            this.tileStartLauncher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileStartLauncher.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileStartLauncher.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileStartLauncher.UseSelectable = true;
            this.tileStartLauncher.Click += new System.EventHandler(this.tileStartLauncher_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(930, 46);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 506);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 506);
            this.MinimumSize = new System.Drawing.Size(930, 506);
            this.Name = "frmSetup";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "MineLauncher - Setup";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.frmSetup_Shown);
            this.tcMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.pnlProfiles_Edit.ResumeLayout(false);
            this.pnlProfiles_Edit.PerformLayout();
            this.metroTabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbTheme;
        private MetroFramework.Controls.MetroButton btnLogin_DoLogin;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbLogin_Password;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbLogin_Username;
        private MetroFramework.Controls.MetroTile tileTheme_Last;
        private MetroFramework.Controls.MetroTile tileTheme_Next;
        private MetroFramework.Controls.MetroTile tileWelcome_Next;
        private MetroFramework.Controls.MetroTile tileLogin_Last;
        private MetroFramework.Controls.MetroTile tileLogin_Next;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile tileProfile_Last;
        private MetroFramework.Controls.MetroTile tileProfile_Next;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroPanel pnlProfiles_Edit;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Custom;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Alpha;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Beta;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Snapshot;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroToggle toggleProfiles_Edit_ShowVersion_Release;
        private MetroFramework.Controls.MetroButton btnProfile_Edit_Save;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_Directory;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_Name;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroComboBox cbProfiles_Edit_Version;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile tileStartLauncher;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle toggleLogin_UseOfflineMode;
        private MetroFramework.Controls.MetroLabel lblProfiles_Edit_Offline_PlayerName;
        private MetroFramework.Controls.MetroTextBox tbProfiles_Edit_Offline_PlayerName;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btnProfiles_ImportFromOriginalLauncher;
    }
}