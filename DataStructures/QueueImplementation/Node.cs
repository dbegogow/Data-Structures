namespace QueueImplementation
{
    public class Node<T>
    {
        public Node(T value, Node<T> head)
        {
            this.Value = value;
            this.Head = head;
        }

        public T Value { get; }

        public Node<T> Head { get; }
    }
}
