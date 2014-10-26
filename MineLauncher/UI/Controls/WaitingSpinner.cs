using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace MineLauncher.UI.Controls
{
    internal class WaitingSpinner : Control
    {
        
        private int _angle = 0;
        private bool _angle_reverse = false;

        public WaitingSpinner()
        {
            this.MinimumSize = new Size(150, 150);
            this.DoubleBuffered = true;
            Timer tmr = new Timer();
            tmr.Interval = 1;
            tmr.Tick += new EventHandler((object sender, EventArgs e) => 
            {
                if(_angle_reverse)
                {
                    _angle--;
                    _angle--;
                    _angle--;
                }
                else
                {
                    _angle++;
                    _angle++;
                    _angle++; 
                }

                if(_angle > 360)
                {
                    _angle_reverse = true;
                }
                else if (_angle < 0)
                {
                    _angle_reverse = false;
                }

                this.Refresh();
            });
            tmr.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.MinimumSize = new Size(150, 150);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            e.Graphics.FillPie(new SolidBrush(Color.FromArgb(0, 174, 219)), this.ClientRectangle, 270, _angle);
            e.Graphics.FillPie(new SolidBrush(Color.FromArgb(17, 17, 17)), new Rectangle(30, 30, this.Width - 60, this.Height - 60), 270, 360);

            base.OnPaint(e);
        }

    }
}
