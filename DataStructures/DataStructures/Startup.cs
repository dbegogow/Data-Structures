using PriorityQueueImplementation;
using System;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var priorityQueue = new PriorityQueue<int>();

            priorityQueue.Insert(3);
            priorityQueue.Insert(1);
            priorityQueue.Insert(2);
            priorityQueue.Insert(5);

            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
        }
    }
}
