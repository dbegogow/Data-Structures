using System.Collections.Generic;

namespace LinkedListImplementation
{
    public interface ILinkedList<T> : IEnumerable<T>
    {
        int Count { get; }

        void AddFirst(T item);

        void AddLast(T item);

        void AddAfter(T item, T newItem);

        void AddBefore(T item, T newItem);

        void Clear();

        bool Contains(T item);

        bool Remove(T item);
    }
}
