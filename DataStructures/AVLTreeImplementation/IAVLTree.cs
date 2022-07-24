namespace AVLTreeImplementation
{
    public interface IAVLTree<T> where T : IComparable<T>
    {
        bool Contains(T item);

        void Insert(T item);

        void Delete(T item);
    }
}
