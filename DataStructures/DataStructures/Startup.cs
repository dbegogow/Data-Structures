using System;
using System.Linq;
//using System.Collections.Generic;
using ListImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            //var list = new List<int> { 1, 2, 3 };

            //Console.WriteLine(list.Remove(3));
            //;

            var list = new List<int> { 1, 2, 3 };
            var list1 = new int[3];

            list.CopyTo(list1, 0);
        }
    }
}
