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
    public class Menu
    {
        private readonly List<Control> menuItems = new List<Control>();

        protected T AddMenuItem<T>(PointF position, PointF size) where T : Control, new()
        {
            T control = new T();
            control.Location = new Point(
                (int)((Window.instance.Width / 2) - (Window.cellWidth * size.X / 2) + (Window.cellWidth * position.X)),
                (int)((Window.instance.Height / 2) - (Window.cellHeight * size.Y / 2) - (Window.cellWidth * position.Y))
            );
            control.Size = new Size(
                (int)(Window.cellWidth * size.X),
                (int)(Window.cellHeight * size.Y)
            );
            menuItems.Add(control);
            return control;
        }

        protected void DrawImage(Image image, PointF position, PointF size)
        {
            var background = new Bitmap((int)(Window.cellWidth * size.X), (int)(Window.cellHeight * size.Y));
            Window.graphics.DrawImage(
                image,
                (Window.instance.Width / 2) - (Window.cellWidth * size.X / 2) + (Window.cellWidth * position.X),
                (Window.instance.Height / 2) - (Window.cellHeight * size.Y / 2) - (Window.cellWidth * position.Y),
                Window.cellWidth * size.X,
                Window.cellHeight * size.Y
            );
        }

        public void InitializeMenu()
        {
            foreach (Control control in menuItems)
            {
                Window.instance.Controls.Add(control);
            }
        }
    }
}
