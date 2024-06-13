using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class AlgorythmT1
    {
        static void Main(string[] args)
        {
            TypedStack<int> stack = new TypedStack<int>();
            stack.Add(1);
            stack.Add(3);
            stack.Add(2);
            Console.WriteLine($"The one member removed was {stack.Remove()}");
            TypedQueue<string> queue = new TypedQueue<string>();
            queue.Add("A");
            queue.Add("B");
            queue.Add("C");
            Console.WriteLine($"The one member removed was {queue.Remove()}");
            Console.ReadLine();
        }
    }
    class TypedStack<T>
    {
        List<T> list;
        public TypedStack()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Remove()
        {
            T first = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return first;
        }
    }
    class TypedQueue<T>
    {
        List<T> list;
        public TypedQueue()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Insert(0, item);
        }

        public T Remove()
        {
            T first = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return first;
        }
    }
}