using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(23);
            list.Add(35);
            list.Add(56);
            list.Add(75);
            list.Add(111);
            list.Insert(3, 44);
            list.Insert(7, 250);
            list.Display();
            list.DeleteFirstElement();
            list.Display();
        }
    }
}
