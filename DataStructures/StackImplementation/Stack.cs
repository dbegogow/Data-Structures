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
            throw new System.NotImplementedException();
        }

        public void Push(T item)
        {
            var newItem = new Node<T>(item, _top);
            this._top = newItem;
        }

        public T Pop()
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
    }
}
