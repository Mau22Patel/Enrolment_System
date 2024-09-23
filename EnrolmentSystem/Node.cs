using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class Node <T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public override string ToString()
        {
            return "value:" + Value + "Node:" + Next;
        }
    }
}
