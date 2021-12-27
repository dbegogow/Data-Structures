using System.Collections.Generic;

namespace LinkedListImplementation
{
    public interface ILinkedList<T> : ICollection<T>
    {
        void AddFirst(T item);

        void AddLast(T item);

        void AddAfter(T item, T newItem);

        void AddBefore(T item, T newItem);
    }
}
