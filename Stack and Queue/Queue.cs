using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class Queue
    {
        Node Top;
        public void enqueue(int data)
        {
            Node node = new Node(data);
            if(Top == null)
            {
                Top = node;
            }
            else
            {
                Node temp= Top;
                while(temp.Next != null)
                {
                    temp= temp.Next;
                }
                temp.Next = node;
            }
            Console.WriteLine(node.data + " is enqueued in queue");
        }
        public void Display()
        {
            Node temp= Top;
            Console.WriteLine("\n*****Queue*****");
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Next;
            }
        }
        public void dequeue()
        {
            Node temp = Top;
            Top = temp.Next;
            Console.WriteLine(temp.data + " is dequque from stack");
        }

    }
}
