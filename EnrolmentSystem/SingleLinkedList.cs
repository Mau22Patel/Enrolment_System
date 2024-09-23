using System.Collections;
using System.Collections.Generic;

namespace EnrolmentSystem
{
    public class SingleLinkedList<T> : ICollection<T>
    {
        public SingleLinkListNode<T> Head { get; private set; }
        public SingleLinkListNode<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new SingleLinkListNode<T>(value));
        }

        public void AddFirst(SingleLinkListNode<T> node)
        {
            var temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }
        }

        public void AddLast(T value)
        {
            AddLast(new SingleLinkListNode<T>(value));
        }

        public void AddLast(SingleLinkListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    var current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
        }

        public void Add(T item)
        {
            AddLast(item); // Changed to AddLast for consistency
        }

        public bool Contains(T item)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            var current = Head;
            while (current != null && arrayIndex < array.Length)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly => false;

        public bool Remove(T item)
        {
            SingleLinkListNode<T> previous = null;
            var current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        // Removing the head
                        Head = current.Next;
                    }

                    if (current.Next == null) // Updating tail
                    {
                        Tail = previous;
                    }

                    Count--;
                    return true; // Item removed successfully
                }

                previous = current;
                current = current.Next;
            }

            return false; // Item not found
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
    }

}
