using System;
using ListImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new List<string> { "1", "2", "3" };

            Console.WriteLine(list.Contains(null));
        }
    }
}
