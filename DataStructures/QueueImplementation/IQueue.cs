using System.Collections.Generic;

namespace QueueImplementation
{
    public interface IQueue<T> : IEnumerable<T>
    {
        void Enqueue(T item);

        T Dequeue();

        T Peek();

        bool Contains(T item);
    }
}
