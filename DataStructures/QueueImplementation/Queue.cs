using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueImplementation
{
    public class Queue<T> : IQueue<T>
    {
        private Node<T> _head;

        public int Count { get; private set; }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Enqueue(T item)
        {
            var newNode = new Node<T>(item);

            if (this._head == null)
            {
                this._head = newNode;
            }
            else
            {
                var currentNode = this._head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
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

        private void ValidateEmptyStack()
        {
            if (this._head == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }
        }
    }
}
