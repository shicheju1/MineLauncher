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
            this.minecraftLoadingAnimation1 = new MineLauncher.UI.Controls.MinecraftLoadingAnimation();
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
            // minecraftLoadingAnimation1
            // 
            this.minecraftLoadingAnimation1.BackColor = System.Drawing.Color.White;
            this.minecraftLoadingAnimation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minecraftLoadingAnimation1.Location = new System.Drawing.Point(235, 68);
            this.minecraftLoadingAnimation1.Name = "minecraftLoadingAnimation1";
            this.minecraftLoadingAnimation1.Size = new System.Drawing.Size(180, 180);
            this.minecraftLoadingAnimation1.TabIndex = 4;
            this.minecraftLoadingAnimation1.Text = "minecraftLoadingAnimation1";
            // 
            // frmStarting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 302);
            this.Controls.Add(this.minecraftLoadingAnimation1);
            this.Controls.Add(this.lblInfo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
        private UI.Controls.MinecraftLoadingAnimation minecraftLoadingAnimation1;
    }
}