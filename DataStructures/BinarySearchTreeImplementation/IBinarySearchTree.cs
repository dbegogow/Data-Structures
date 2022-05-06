using System.Collections.Generic;

namespace BinaryTreeImplementation
{
    public interface IBinarySearchTree<T>
    {
        bool Add(T item);

        IEnumerable<T> InOrder();

        IEnumerable<T> PreOrder();
    }
}
