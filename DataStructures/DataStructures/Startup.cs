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
            list.AddFirst(-1);
            list.AddLast(2);
            list.AddLast(3);

            list.AddAfter(2, 10);

            ;
        }
    }
}
