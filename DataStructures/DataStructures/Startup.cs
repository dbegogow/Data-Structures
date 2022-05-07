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

            var rnd = new Random();

            for (int i = 0; i < 10_000; i++)
            {
                var number = rnd.Next(0, 500_000);

                binaryTree.Add(number);
            }

        }
    }
}
