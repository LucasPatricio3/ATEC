using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnBasedBattlerProject.Properties;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Components
{
    internal class SpriteRenderer : GameComponent
    {
        private Image image = Resources.MissingTextureBlock;

        public void SetImage(Image image)
        {
            this.image = image;
        }
        public void DrawImage()
        {
            PointF position = ObjRef.position;
            PointF scale = ObjRef.scale;

            var background = new Bitmap((int)(Window.cellWidth * scale.X), (int)(Window.cellHeight * scale.Y));
            Window.graphics.DrawImage(
                this.image,
                (Window.instance.Width / 2) - (image.Width * scale.X / 2 * Window.resizeConst.X) + (Window.cellWidth * position.X),
                (Window.instance.Height / 2) - (image.Height * scale.Y / 2 * Window.resizeConst.Y) - (Window.cellHeight * position.Y),
                image.Width * scale.X * Window.resizeConst.X,
                image.Height * scale.Y * Window.resizeConst.Y   
            );
        }
    }
}
