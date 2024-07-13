using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnBattleProject.Utilities
{
    internal class PixelImage : UserControl
    {
        public void SetImage(Bitmap image)
        {
            var newImage = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.PixelOffsetMode = PixelOffsetMode.Half;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(image, 0, 0, this.Width, this.Height);
            }
            Window.Instance.DrawToBitmap(newImage, Bounds);
        }

    }
}
