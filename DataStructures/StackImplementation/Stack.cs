using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    public class Stack<T> : IStack<T>
    {
        private Node<T> _top;

        public int Count { get; private set; }

        public bool Contains(T item)
        {
            var currentNode = this._top;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public void Push(T item)
        {
            var newItem = new Node<T>(item, _top);
            this._top = newItem;

            this.Count++;
        }

        public T Pop()
        {
            this.ValidateEmptyStack();

            var removedItem = this._top.Value;
            this._top = _top.Next;

            this.Count--;

            return removedItem;
        }

        public T Peek()
        {
            this.ValidateEmptyStack();

            return this._top.Value;
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
            if (this._top == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }
    }
}
