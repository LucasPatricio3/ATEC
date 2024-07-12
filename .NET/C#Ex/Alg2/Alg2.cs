using System;
using System.Collections.Generic;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Adicionar("ABABA");
            Console.ReadLine();
        }
    }
    internal class LinkedList<T>
    {
        public int Lenght;
        public LinkedNode<T> top;

        public void Adicionar(T item)
        {
            LinkedNode<T> node = new LinkedNode<T>(item);
            if (Lenght == 0)
            {
                top = node;
            }

        }
    }
    internal class LinkedNode<T>
    {
        public LinkedNode(T item)
        {
            this.item = item;
            next = null;
        }
        public T item;
        public LinkedNode<T>? next;
    }
}