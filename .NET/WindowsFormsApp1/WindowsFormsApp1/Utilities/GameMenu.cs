using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurnBasedBattlerProject.Components;
using TurnBasedBattlerProject.Properties;

namespace TurnBasedBattlerProject.Utilities
{
    public class GameMenu
    {
        public readonly List<GameObject> gameObjects = new List<GameObject>();
        public readonly List<Control> menuItems = new List<Control>();

        protected T AddMenuItem<T>(PointF position, PointF scale) where T : Control, new()
        {
            T control = new T();
            control.Location = new Point(
                (int)((Game.instance.Width / 2) - (Game.cellWidth * scale.X / 2) + (Game.cellWidth * position.X)),
                (int)((Game.instance.Height / 2) - (Game.cellHeight * scale.Y / 2) - (Game.cellWidth * position.Y))
            );
            control.Size = new Size(
                (int)(Game.cellWidth * scale.X),
                (int)(Game.cellHeight * scale.Y)
            );
            menuItems.Add(control);
            return control;
        }
        protected GameObject AddObject(string name, PointF position, PointF scale)
        {
            if (FindObject(name) != null)
            {
                Debug.WriteLine($"WARNING: GameObject({name}) already exists in this Menu!");
                return null;
            }
            GameObject gameObject = new GameObject();
            gameObject.name = name;
            gameObject.position = position;
            gameObject.scale = scale;
            gameObjects.Add(gameObject);
            return gameObject;
        }

        protected GameObject AddObject(GameObject gameObject)
        {
            if (FindObject(gameObject.name) != null)
            {
                Debug.WriteLine($"WARNING: GameObject({gameObject.name}) already exists in this Menu!");
                return null;
            }
            gameObjects.Add(gameObject);
            return gameObject;
        }

        public GameObject FindObject(string name)
        {
            foreach (GameObject gObj in gameObjects)
            {
                if (gObj.name == name)
                {
                    return gObj;
                }
                if (gObj.GetChildren() != null)
                {
                    foreach (GameObject children in gObj.GetChildren())
                    {
                        if (children.name == name)
                        {
                            return children;
                        }
                    }
                }

            }
            return null;
        }
        public void InitializeMenuControls()
        {
            Game.instance.Controls.Clear();
            foreach (Control control in menuItems)
            {
                Game.instance.Controls.Add(control);
            }

            //TestPoint
            //Window.graphics.DrawImage(Resources.MissingTextureBlock, Window.instance.Width/2-16, Window.instance.Height / 2-16);
        }
        public void DrawObjects(GameObject[] gameObjects)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                var renderer = gameObject.GetComponent<SpriteRenderer>();
                if (renderer != null)
                {
                    renderer.DrawImage();
                }
                if (gameObject.GetChildren() != null)
                {
                    DrawObjects(gameObject.GetChildren());
                }
            }
        }
    }
}
