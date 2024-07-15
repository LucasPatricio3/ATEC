using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnBasedBattlerProject.Utilities
{
    public class ImageButon : Button
    {
        private Bitmap defaultState;
        private Bitmap onHoverState;
        private Bitmap pressedState;

        public ImageButon()
        {
            this.defaultState = Properties.Resources.BasicBlock;
            this.onHoverState = Properties.Resources.BasicBlock;
            this.pressedState = Properties.Resources.BasicBlock;

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.TabStop = false;

            this.MouseEnter += delegate (object sender, EventArgs e) { SetBackground(onHoverState); };
            this.MouseLeave += delegate (object sender, EventArgs e) { SetBackground(defaultState); };
            this.MouseClick += delegate (object sender, MouseEventArgs e) { SetBackground(pressedState); };
        }

        internal void MapBitmaps(Bitmap defaultState, Bitmap onHoverState, Bitmap pressedState)
        {
            this.defaultState = defaultState;
            this.onHoverState = onHoverState;
            this.pressedState = pressedState;
            SetBackground(defaultState);
        }
        private void SetBackground(Bitmap image)
        {
            var background = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(background))
            {
                g.PixelOffsetMode = PixelOffsetMode.Half;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(image, 0, 0, this.Width, this.Height);
            }
            this.Image = background;
        }

        public override void NotifyDefault(bool value) { }
    }
}
