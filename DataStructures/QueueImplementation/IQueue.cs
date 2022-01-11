using System.Collections.Generic;

namespace QueueImplementation
{
    public interface IQueue<T> : IEnumerable<T>
    {
        int Count { get; }

        bool Contains(T item);

        void Enqueue(T item);

        T Dequeue();

        T Peek();
    }
}
