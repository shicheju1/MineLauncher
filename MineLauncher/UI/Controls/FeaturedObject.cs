using System;
 
using MetroFramework.Controls;

namespace MineLauncher.UI.Controls
{

    public enum FeaturedObjectType
    {
        ModPack,
        News,
        Featured,
        Other
    }

    internal class FeaturedObject : MetroUserControl
    {
        private MetroTextBox tbTitle;
        private MetroLabel lblType;
        private System.Windows.Forms.RichTextBox rtbDescr;

        public FeaturedObject(string title, string descr, FeaturedObjectType type)
        {
            InitializeComponent();
            this.tbTitle.Text = title;
            this.rtbDescr.Text = descr;
            if (type == FeaturedObjectType.Featured)
                lblType.Text = "Featured: ";
            else if (type == FeaturedObjectType.ModPack)
                lblType.Text = "Modpack: ";
            else if (type == FeaturedObjectType.News)
                lblType.Text = "News: ";
            else
                lblType.Text = "Other: ";
        }

        private void InitializeComponent()
        {
            this.tbTitle = new MetroFramework.Controls.MetroTextBox();
            this.rtbDescr = new System.Windows.Forms.RichTextBox();
            this.lblType = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbTitle.Lines = new string[0];
            this.tbTitle.Location = new System.Drawing.Point(127, 3);
            this.tbTitle.MaxLength = 32767;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.ReadOnly = true;
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTitle.SelectedText = "";
            this.tbTitle.Size = new System.Drawing.Size(780, 23);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbTitle.UseSelectable = true;
            // 
            // rtbDescr
            // 
            this.rtbDescr.BackColor = System.Drawing.Color.White;
            this.rtbDescr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescr.Location = new System.Drawing.Point(127, 32);
            this.rtbDescr.Name = "rtbDescr";
            this.rtbDescr.ReadOnly = true;
            this.rtbDescr.Size = new System.Drawing.Size(780, 99);
            this.rtbDescr.TabIndex = 2;
            this.rtbDescr.Text = "";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 6);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(24, 19);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "{0}";
            // 
            // FeaturedObject
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.rtbDescr);
            this.Controls.Add(this.tbTitle);
            this.MaximumSize = new System.Drawing.Size(910, 134);
            this.MinimumSize = new System.Drawing.Size(910, 134);
            this.Name = "FeaturedObject";
            this.Size = new System.Drawing.Size(910, 134);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }

}
