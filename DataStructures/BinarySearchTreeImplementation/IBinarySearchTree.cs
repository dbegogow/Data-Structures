using System.Collections.Generic;

namespace BinarySearchTreeImplementation
{
    public interface IBinarySearchTree<T>
    {
        bool Add(T item);

        bool Remove(T item);

        bool Contains(T item);

        IEnumerable<T> InOrder();

        IEnumerable<T> PreOrder();
    }
}
