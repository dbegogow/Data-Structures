namespace PriorityQueueImplementation
{
    public interface IPriorityQueue<T> where T : IComparable<T>
    {
        int Size { get; }

        void Insert(T element);

        T Peek();

        T Dequeue();
    }
}
