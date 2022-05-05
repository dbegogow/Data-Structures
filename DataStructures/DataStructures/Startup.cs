using System;
using BinaryTreeImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Add(17);
            binaryTree.Add(9);
            binaryTree.Add(25);
            binaryTree.Add(3);
            binaryTree.Add(11);
            binaryTree.Add(20);
            binaryTree.Add(31);
        }
    }
}
