namespace AVLTreeImplementation
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public int Height { get; set; }
    }
}
