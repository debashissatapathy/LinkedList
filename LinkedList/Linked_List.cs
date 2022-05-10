using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class AddNode<T>
    {
        public T data;
        public AddNode<T> Next;
        public AddNode(T data)
        {
            this.data = data;
        }
    }
    class Linked_List<T>
    {
       

        internal AddNode<T> head;
        internal void Add(T data)
        {
            AddNode<T> nd = new AddNode<T>(data);
            if(this.head == null)
            {
                this.head = nd;
            }
            else
            {
                AddNode<T> temp = head;
                while(temp.Next!=null)
                {
                    temp = temp.Next;
                }
                temp.Next = nd;
            }
            Console.WriteLine("{0} inserted into lined list", nd.data);
        }
        internal void Display()
        {
            AddNode<T> temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.Next;
            }
            Console.WriteLine("\n");
        }
        
    }
}
