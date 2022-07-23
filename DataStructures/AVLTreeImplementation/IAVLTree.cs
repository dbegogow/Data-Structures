namespace AVLTreeImplementation
{
    public interface IAVLTree<T> where T : IComparable<T>
    {
        bool Contains(T item);

        void Insert(T item);

        void EachInOrder(Action<T> action);

        Node<T> Insert(Node<T> node, T value);
    }
}
