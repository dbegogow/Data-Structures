using System;
using QueueImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            //var queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //queue.Dequeue();

            //queue.

            var queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.Peek());

            Console.WriteLine("----");

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
