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
                (int)((Window.instance.Width / 2) - (Window.cellWidth * scale.X / 2) + (Window.cellWidth * position.X)),
                (int)((Window.instance.Height / 2) - (Window.cellHeight * scale.Y / 2) - (Window.cellWidth * position.Y))
            );
            control.Size = new Size(
                (int)(Window.cellWidth * scale.X),
                (int)(Window.cellHeight * scale.Y)
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
            foreach (Control control in menuItems)
            {
                Window.instance.Controls.Add(control);
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
