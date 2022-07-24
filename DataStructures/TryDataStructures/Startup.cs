using AVLTreeImplementation;

namespace TryDataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var avlTree = new AVLTree<int>();

            avlTree.Insert(10);
            avlTree.Insert(9);
            avlTree.Insert(8);
            avlTree.Insert(40);
            avlTree.Insert(50);
            avlTree.Insert(60);
            avlTree.Insert(70);
            avlTree.Insert(80);

            ;
        }
    }
}
