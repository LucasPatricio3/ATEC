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
        private List<GameObject> children;
        private List<GameComponent> components = new List<GameComponent>();

        public GameObject()
        {
            
        }
        public GameObject(string name, PointF position, PointF scale)
        {
            this.name = name;
            this.position = position;
            this.scale = scale;
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
