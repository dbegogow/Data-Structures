using System.Collections.Generic;

namespace LinkedListImplementation
{
    public interface ILinkedList<T> : IEnumerable<T>
    {
        int Count { get; }

        void AddFirst(T item);

        void AddLast(T item);

        void Clear();

        bool AddAfter(T item, T newItem);

        bool AddBefore(T item, T newItem);

        bool Contains(T item);

        bool Remove(T item);
    }
}
