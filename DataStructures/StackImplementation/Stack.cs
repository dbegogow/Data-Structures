using System.Collections;
using System.Collections.Generic;

namespace StackImplementation
{
    public class Stack<T> : IStack<T>
    {
        public int Count { get; }

        public void Push(T item)
        {
            throw new System.NotImplementedException();
        }

        public T Pop()
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(T item)
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
