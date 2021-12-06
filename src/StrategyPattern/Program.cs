using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new Add());
            Console.WriteLine(context.ExecuteStrategy(3, 5));
            Context context1 = new Context(new Subtract());
            Console.WriteLine(context1.ExecuteStrategy(4,2));
        }
    }
}
