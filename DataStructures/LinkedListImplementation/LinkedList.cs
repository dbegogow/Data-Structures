using System.Collections;
using System.Collections.Generic;

namespace LinkedListImplementation
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            var newNode = new Node<T>(item);

            if (this._head == null)
            {
                this.AddFirstItem(newNode);
                return;
            }

            newNode.Next = this._head;
            this._head = newNode;

            this.Count++;
        }

        public void AddLast(T item)
        {
            var newNode = new Node<T>(item);

            if (this._tail == null)
            {
                this.AddFirstItem(newNode);
                return;
            }

            new
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

        private void AddFirstItem(Node<T> newNode)
        {
            this._head = newNode;
            this._tail = newNode;
        }
    }
}
