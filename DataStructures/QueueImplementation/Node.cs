namespace QueueImplementation
{
    public class Node<T>
    {
        public Node(T value)
            => this.Value = value;

        public T Value { get; }

        public Node<T> Next { get; set; }
    }
}
