using TreeImplementation;

namespace DataStructures
{
    public class StartUp
    {
        public static void Main()
        {
            var tree = new Tree<int>(
                1,
                new Tree<int>(
                                    2,
                                    new Tree<int>(
                                        10,
                                        new Tree<int>(4),
                                        new Tree<int>(7)),
                                    new Tree<int>(
                                        20,
                                        new Tree<int>(5),
                                        new Tree<int>(9))
                                    ),
                new Tree<int>(
                    3,
                    new Tree<int>(60),
                    new Tree<int>(80)
                    )
            );

            var elements = tree.OrderDfs();

            ;
        }
    }
}
