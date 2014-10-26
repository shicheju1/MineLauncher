namespace MineLauncher
{
    partial class frmStarting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStarting));
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.win8ProgressRing1 = new MineLauncher.UI.Controls.Win8ProgressRing();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblInfo.Location = new System.Drawing.Point(23, 266);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(624, 19);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "It seems to take longer than we thought...";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblInfo.Visible = false;
            // 
            // win8ProgressRing1
            // 
            this.win8ProgressRing1.Control_Height = 200;
            this.win8ProgressRing1.Indicator_Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.win8ProgressRing1.Location = new System.Drawing.Point(235, 63);
            this.win8ProgressRing1.Name = "win8ProgressRing1";
            this.win8ProgressRing1.Refresh_Rate = 40;
            this.win8ProgressRing1.Size = new System.Drawing.Size(200, 200);
            this.win8ProgressRing1.TabIndex = 3;
            // 
            // frmStarting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 302);
            this.Controls.Add(this.win8ProgressRing1);
            this.Controls.Add(this.lblInfo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 302);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 302);
            this.Movable = false;
            this.Name = "frmStarting";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Text = "Starting MineLauncher...";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStarting_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblInfo;
        private UI.Controls.Win8ProgressRing win8ProgressRing1;
    }
}