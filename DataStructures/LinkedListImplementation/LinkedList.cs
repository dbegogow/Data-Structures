using System.Collections;
using System.Collections.Generic;

namespace LinkedListImplementation
{
    public class LinkedList<T> : ILinkedList<T>
    {

        public int Count { get; }

        public void AddFirst(T item)
        {
            throw new System.NotImplementedException();
        }

        public void AddLast(T item)
        {
            throw new System.NotImplementedException();
        }

        public void AddAfter(T item, T newItem)
        {
            throw new System.NotImplementedException();
        }

        public void AddBefore(T item, T newItem)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
