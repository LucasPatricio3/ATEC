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
    public class SpriteRenderer : GameComponent
    {
        public Bitmap image = Resources.MissingTextureBlock;
        public void DrawImage()
        {
            PointF position = ObjRef.position;
            PointF scale = ObjRef.scale;

            var background = new Bitmap((int)(Game.cellWidth * scale.X), (int)(Game.cellHeight * scale.Y));
            Game.graphics.DrawImage(
                this.image,
                (Game.instance.Width / 2) - (image.Width * scale.X / 2 * Game.resizeConst.X) + (Game.cellWidth * position.X),
                (Game.instance.Height / 2) - (image.Height * scale.Y / 2 * Game.resizeConst.Y) - (Game.cellHeight * position.Y),
                image.Width * scale.X * Game.resizeConst.X,
                image.Height * scale.Y * Game.resizeConst.Y   
            );
        }

        public void Flip()
        {
            image.RotateFlip(RotateFlipType.Rotate180FlipY);
        }
    }
}
