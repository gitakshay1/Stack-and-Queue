using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    public class Node
    {
        public Node Next;
        public int data;
        public Node(int data)
        {
            this.data = data;
        }
    }
}
