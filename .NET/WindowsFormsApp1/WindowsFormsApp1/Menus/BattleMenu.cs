using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnBasedBattlerProject.Components;
using TurnBasedBattlerProject.Properties;
using TurnBasedBattlerProject.Utilities;

namespace TurnBasedBattlerProject.Menus
{
    public class BattleMenu : GameMenu
    {
        public BattleMenu()
        {
            //Char 1
            var character1 = AddObject(Game.instance.character1);
            character1.MoveTo(new PointF(6, 3));
            character1.GetComponent<SpriteRenderer>().Flip();

            //Char 2
            var character2 = AddObject(Game.instance.character2);
            character2.MoveTo(new PointF(7, 0));
            character2.GetComponent<SpriteRenderer>().Flip();

            //Char 3
            var character3 = AddObject(Game.instance.character3);
            character3.MoveTo(new PointF(6, -2.5f));
            character3.GetComponent<SpriteRenderer>().Flip();

            //Enemy
            var enemy1 = AddObject("EvilKnight", new PointF(-7, 0), new PointF(1, 1));
            SpriteRenderer enemyRend = enemy1.AddComponent<SpriteRenderer>();
            enemyRend.image = Resources.evilKnight;

            //Action Bar
            var actionBarBack = AddObject("actionBarBreak", new PointF(0, 0), new PointF(1, 1));
            SpriteRenderer actionBarBackRend = actionBarBack.AddComponent<SpriteRenderer>();
            actionBarBackRend.image = Resources.ActionBar;

            var skill1Button = AddMenuItem<ImageButon>(new PointF(5, -7.25f), new PointF(2,2));
            skill1Button.MapBitmaps(Resources.BasicBlock, Resources.BasicBlock, Resources.BasicBlock);

            var skill2Button = AddMenuItem<ImageButon>(new PointF(8, -7.25f), new PointF(2, 2));
            skill2Button.MapBitmaps(Resources.BasicBlock, Resources.BasicBlock, Resources.BasicBlock);

            var skill3Button = AddMenuItem<ImageButon>(new PointF(11, -7.25f), new PointF(2, 2));
            skill3Button.MapBitmaps(Resources.BasicBlock, Resources.BasicBlock, Resources.BasicBlock);

            //Initialize Battle System
            BattleSys battleSystem = new BattleSys(
                skill1Button, skill2Button, skill3Button,
                new GameObject[] { character1, character2, character3 },
                new GameObject[] { enemy1 }
            );
        }
    }
}
