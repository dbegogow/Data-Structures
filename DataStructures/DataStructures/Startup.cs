using System;
using System.Collections.Generic;
using BinaryTreeImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Add(10);
            binaryTree.Add(8);
            binaryTree.Add(7);
            binaryTree.Add(17);
            binaryTree.Add(30);
            binaryTree.Add(21);
            binaryTree.Add(18);
            binaryTree.Add(28);
            binaryTree.Add(15);

            var list = new List<int> { 10, 8, 7, 17, 30, 21, 18, 28, 15 };
            list.Sort();

            Console.WriteLine(string.Join(", ", binaryTree.InOrder()));
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
