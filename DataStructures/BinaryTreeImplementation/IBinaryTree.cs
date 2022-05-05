using System.Collections.Generic;

namespace BinaryTreeImplementation
{
    public interface IBinaryTree<T>
    {
        bool Add(T item);

        IEnumerable<T> InOrder();
    }
}
