namespace PriorityQueueImplementation
{
    public interface IPriorityQueue<T>
    {
        void Insert(T element);

        T Pull();

        T Peek();
    }
}
