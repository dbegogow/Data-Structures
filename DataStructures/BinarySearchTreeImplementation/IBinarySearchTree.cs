using System.Collections.Generic;

namespace BinarySearchTreeImplementation
{
    public interface IBinarySearchTree<T>
    {
        bool Add(T item);

        IEnumerable<T> InOrder();

        IEnumerable<T> PreOrder();
    }
}
