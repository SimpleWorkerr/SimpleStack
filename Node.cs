using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStack
{
    internal class Node<T>
    {
        public Node<T>? pPrev { get; private set; }
        public T Data { get; set; }

        public Node(T data, Node<T>? prevNode = null)
        {
            Data = data;
            pPrev = prevNode;
        }
        
    }
}
