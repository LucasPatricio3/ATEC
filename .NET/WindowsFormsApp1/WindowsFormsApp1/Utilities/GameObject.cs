using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedBattlerProject.Utilities
{
    public class GameObject
    {
        public string name;
        public PointF position;
        public PointF scale;
        public GameObject parent = null;
        private List<GameComponent> components = new List<GameComponent>();
        private List<GameObject> children;

        public GameObject()
        {
            
        }
        public GameObject(string name, PointF position, PointF scale)
        {
            this.name = name;
            this.position = position;
            this.scale = scale;
        }

        public void MoveTo(PointF position)
        {
            if (children != null)
            {
                foreach (GameObject child in children)
                {
                    PointF newPositionForChild = new PointF(
                        child.position.X + position.X - this.position.X,
                        child.position.Y + position.Y - this.position.Y
                        );
                    child.MoveTo(newPositionForChild);
                }
            }
            this.position = position;
            Game.instance.Refresh();
        }

        public GameObject AddChild(GameObject child)
        {
            if (children == null) children = new List<GameObject>();
            child.parent = this;
            children.Add(child);
            return child;
        }
        public GameObject GetChild(int index)
        {
            if (children == null) {
                Debug.WriteLine("WARNING: Object has no Children!");
                return null;
            }
            else if (index > children.Count)
            {
                Debug.WriteLine($"WARNING: Child({index}) does not exist!");
                return null;
            }
            return children[index];
        }
        public void RemoveChild(GameObject child)
        {
            if (children == null)
            {
                Debug.WriteLine("WARNING: Object has no Children!");
                return;
            }
            children.Remove(child);
        }
        public GameObject[] GetChildren()
        {
            if (children != null)
            {
                return children.ToArray();
            }
            else
            {
                return null;
            }
        }
        public void Destroy()
        {
            if (parent != null) parent.RemoveChild(this);
            name = null;
            position = PointF.Empty;
            scale = PointF.Empty;
            components.Clear();
            components = null;
            if (children != null) children.Clear();
            children = null;
            if (Game.currentMenu.gameObjects.Contains(this)) Game.currentMenu.gameObjects.Remove(this);
            Game.instance.Refresh();
        }

        public T AddComponent<T>() where T : GameComponent, new()
        {
            foreach (GameComponent c in components)
            {
                if (c.GetType() == typeof(T))
                {
                    Debug.WriteLine($"WARNING: {this.name} already has a component of type {typeof(T).Name}");
                    return null;
                }
            }
            T component = new T();
            component.ObjRef = this;
            components.Add(component);
            return component;
        }    
        public T GetComponent<T>() where T : GameComponent
        {
            foreach (var c in components)
            {
                if (c.GetType() == typeof(T))
                {
                    return (T)c;
                }
            }
            Debug.WriteLine($"WARNING: {this.name} doesn't have a component of type {typeof(T).Name}");
            return null;
        }
    }
}
