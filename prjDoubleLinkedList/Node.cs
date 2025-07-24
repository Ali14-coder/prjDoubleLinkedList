using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDoubleLinkedList
{
    class Node
    {
        public int Value;
        public Node next;
        public Node previous;

        public Node(int value)
        {
            this.Value = value; //returns the value attached to the current node
        }
    }
}
