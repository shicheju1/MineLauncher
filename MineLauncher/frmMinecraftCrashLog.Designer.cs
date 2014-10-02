namespace MineLauncher
{
    partial class frmMinecraftCrashLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMinecraftCrashLog));
            this.rtbCrashLog = new System.Windows.Forms.RichTextBox();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.lblPlayingType = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // rtbCrashLog
            // 
            this.rtbCrashLog.AcceptsTab = true;
            this.rtbCrashLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbCrashLog.BackColor = System.Drawing.SystemColors.Window;
            this.rtbCrashLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCrashLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbCrashLog.DetectUrls = false;
            this.rtbCrashLog.HideSelection = false;
            this.rtbCrashLog.Location = new System.Drawing.Point(23, 166);
            this.rtbCrashLog.Name = "rtbCrashLog";
            this.rtbCrashLog.ReadOnly = true;
            this.rtbCrashLog.Size = new System.Drawing.Size(728, 344);
            this.rtbCrashLog.TabIndex = 3;
            this.rtbCrashLog.Text = "";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(23, 60);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(76, 19);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "{DATETIME}";
            this.lblDateTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPlayingType
            // 
            this.lblPlayingType.AutoSize = true;
            this.lblPlayingType.Location = new System.Drawing.Point(23, 79);
            this.lblPlayingType.Name = "lblPlayingType";
            this.lblPlayingType.Size = new System.Drawing.Size(196, 19);
            this.lblPlayingType.TabIndex = 5;
            this.lblPlayingType.Text = "{CRASHED_WHILE_PLAYING_IN}";
            this.lblPlayingType.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmMinecraftCrashLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 533);
            this.Controls.Add(this.lblPlayingType);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.rtbCrashLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 533);
            this.Name = "frmMinecraftCrashLog";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Sorry, but Minecraft crashed";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.frmMinecraftCrashLog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCrashLog;
        private MetroFramework.Controls.MetroLabel lblDateTime;
        private MetroFramework.Controls.MetroLabel lblPlayingType;
    }
}