using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 3 };

            ICollection<int> list1 = (ICollection<int>) list;

            var list2 = new int[10];

            list1.CopyTo(list2, 0);

            Console.WriteLine(list2[0]);


        }
    }
}
