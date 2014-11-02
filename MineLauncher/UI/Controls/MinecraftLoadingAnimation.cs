using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MineLauncher.UI.Controls
{
    internal class MinecraftLoadingAnimation : Control
    {

        private Image diamond_ore_block = null;
        private List<Image> block_destory_stages = new List<Image>();

        private int block_destory_stage = 0;

        public MinecraftLoadingAnimation()
        {
            this.DoubleBuffered = true;

            // Loading images
            diamond_ore_block = MineLauncher.Properties.Resources.diamond_ore;

            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_0);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_1);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_2);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_3);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_4);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_5);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_6);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_7);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_8);
            block_destory_stages.Add(MineLauncher.Properties.Resources.destroy_stage_9);

            // Start timer
            Timer tmr = new Timer();
            tmr.Interval = 100;
            tmr.Tick += new EventHandler((object sender, EventArgs e) =>
            {
                block_destory_stage++;
                if (block_destory_stage == 10) block_destory_stage = 0;
                this.Refresh();
            });
            tmr.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(this.diamond_ore_block, new Rectangle(0, 0, this.ClientRectangle.Width + 6, this.ClientRectangle.Height + 6));
            if(block_destory_stage > 0)
                e.Graphics.DrawImage(this.block_destory_stages[block_destory_stage - 1], new Rectangle(0, 0, this.ClientRectangle.Width + 6, this.ClientRectangle.Height + 6));

            base.OnPaint(e);
        }

    }
}
