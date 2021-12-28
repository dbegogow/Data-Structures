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
                this.Count++;

                return;
            }

            this._head.Previous = newNode;
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
                this.Count++;

                return;
            }

            this._tail.Next = newNode;
            newNode.Previous = this._tail;
            this._tail = newNode;

            this.Count++;
        }
        public void Clear()
        {
            this._head = null;
            this._tail = null;

            this.Count = 0;
        }

        public bool AddAfter(T item, T newItem)
        {
            var node = this.FindNode(item);

            if (node == null)
            {
                return false;
            }

            this.Count++;

            var nextNode = node.Next;
            var newNode = new Node<T>(newItem);

            if (nextNode == null)
            {
                this.AddLast(newItem);
                return true;
            }

            node.Next = newNode;
            newNode.Previous = node;

            newNode.Next = nextNode;
            nextNode.Previous = newNode;

            return true;
        }

        public bool AddBefore(T item, T newItem)
        {
            var node = this.FindNode(item);

            if (node == null)
            {
                return false;
            }

            this.Count++;

            var previousNode = node.Previous;
            var newNode = new Node<T>(newItem);

            if (previousNode == null)
            {
                this.AddFirst(newItem);
                return true;
            }

            node.Previous = newNode;
            newNode.Next = node;

            newNode.Previous = previousNode;
            previousNode.Next = newNode;

            return true;
        }

        public bool Contains(T item)
            => this.FindNode(item) != null;

        public bool Remove(T item)
        {
            var node = this.FindNode(item);

            if (node == null)
            {
                return false;
            }

            this.Count--;

            var nextNode = node.Next;
            var previousNode = node.Previous;

            if (this.Count == 0)
            {
                this.Clear();
            }
            else
            {
                if (nextNode == null)
                {
                    previousNode.Next = null;
                    this._tail = previousNode;
                }
                else
                {
                    nextNode.Previous = previousNode;
                }

                if (previousNode == null)
                {
                    nextNode.Previous = null;
                    this._head = nextNode;
                }
                else
                {
                    previousNode.Next = nextNode;
                }
            }

            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this._head;

            yield return currentNode.Value;

            while (true)
            {
                currentNode = currentNode.Next;

                if (currentNode == null)
                {
                    break;
                }

                yield return currentNode.Value;
            }
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

        private Node<T> FindNode(T value)
        {
            var currentNode = this._head;

            if (value.Equals(currentNode.Value))
            {
                return this._head;
            }

            while (true)
            {
                currentNode = currentNode.Next;

                if (currentNode == null)
                {
                    return null;
                }

                var currentNodeValue = currentNode.Value;

                if (currentNodeValue.Equals(value))
                {
                    return currentNode;
                }
            }
        }
    }
}
