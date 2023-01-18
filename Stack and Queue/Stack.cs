using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class Stack
    {
        Node Top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (Top == null)
            {
                Top = node;
            }
            else
            {
                Node temp= Top;
                Top = node;
                Top.Next = temp;
            }
            Console.WriteLine(node.data + " is pushed to stact");
        }
        public void Display()
        {
            Node temp= Top;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp= temp.Next;
            }
        }

    }
}
