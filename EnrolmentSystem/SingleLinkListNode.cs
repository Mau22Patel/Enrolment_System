using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    public class SingleLinkListNode <T>
    {
        public T Value { get; set; }
        public SingleLinkListNode<T> Next { get; set; } 

        public SingleLinkListNode(T value)

        {
            Value = value;
        }

    }
}
