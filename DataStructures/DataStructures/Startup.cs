using System;
using LinkedListImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new LinkedList<int>();

           list.AddFirst(1);
           list.AddFirst(0);

           list.AddBefore(0, -1);

           ;
        }
    }
}
