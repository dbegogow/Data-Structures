using System.Collections.Generic;

namespace StackImplementation
{
    public interface IStack<T> : IEnumerable<T>
    {
        int Count { get; }

        void Push(T item);

        T Pop();

        T Peek();

        bool Contains(T item);
    }
}
