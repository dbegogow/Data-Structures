namespace PriorityQueueImplementation
{
    public interface IPriorityQueue<T> where T : IComparable<T>
    {
        int Size { get; }

        void Insert(T item);

        T Peek();

        T Dequeue();
    }
}
