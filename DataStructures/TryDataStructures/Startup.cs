using System;
using AVLTreeImplementation;

namespace TryDataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var avlTree = new AVLTree<int>();

            avlTree.Insert(10);
            avlTree.Insert(5);
            avlTree.Insert(20);
            avlTree.Insert(34);
            avlTree.Insert(1);
            avlTree.Insert(22);
            avlTree.Insert(28);
            avlTree.Insert(45);
            avlTree.Insert(3);
            avlTree.Insert(50);

            Console.WriteLine(avlTree.Contains(20));
        }
    }
}
