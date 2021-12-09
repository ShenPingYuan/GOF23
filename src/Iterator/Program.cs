using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "a";
            a[1] = "b";
            a[2] = "c";
            a[3] = "d";
            a[4] = "e";
            a[5] = "f";

            IIterator iterator = new ConcreteIterator(a);

            object firstItem = iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
