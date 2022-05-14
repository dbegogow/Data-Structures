using BinarySearchTreeImplementation;
using System;

namespace DataStructures
{
    public class StartUp
    {
        public static object StopWatch { get; private set; }

        public static void Main()
        {
            var binaryTree = new BinarySearchTree<int>();

            binaryTree.Add(17);
            binaryTree.Add(9);
            binaryTree.Add(6);
            binaryTree.Add(19);
            binaryTree.Add(18);
            binaryTree.Add(25);
            binaryTree.Add(23);
            binaryTree.Add(27);

            Console.WriteLine(binaryTree.Remove(17));

            ;
        }
    }
}
