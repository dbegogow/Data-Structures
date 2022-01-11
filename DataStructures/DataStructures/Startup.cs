using System;
using StackImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);

            Console.WriteLine(stack.Pop());

            ;
        }
    }
}
