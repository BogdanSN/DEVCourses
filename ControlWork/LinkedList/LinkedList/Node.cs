using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    // The public Class Node will be use for creating new Nodes of LinkedList
    // The Class contain 2 values:
    // - Link to next Node
    // - Dates, which node contains
    public class Node<T>
    {
        public Node<T> next;
        public T data;
    }
}
