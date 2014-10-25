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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(235, 63);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(200, 200);
            this.metroProgressSpinner1.Speed = 3F;
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 5;
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
            // frmStarting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 305);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel lblInfo;
    }
}