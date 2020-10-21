using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " is inserted into the linked list");
        }
        internal void Insert(int position,int data)
        {
            Node node = new Node(data);
            if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                int index = 2;
                Node temp = head;
                while (index != position + 1 || temp != null) 
                {
                    if (index == position)
                    {
                        Node n = temp.next;
                        temp.next = node;
                        node.next = n;
                        
                        break;
                    }
                    temp = temp.next;
                    index++;
                }
                if (index + 1 == position)
                {
                    temp.next = node;
                }
               
            }
        }

        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }


        }
        internal void Pop()
        {
            if (head != null)
            {
                head = head.next;
            }
        }
        internal void PopLast()
        {
            Node temp = head;
            while (temp!= null)
            {
                if (temp.next.next == null)
                {
                    temp.next = null;
                }
                temp = temp.next;
            }
        }
    }
}
