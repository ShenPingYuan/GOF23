using System;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ConcreteBuilder1 builder = new ConcreteBuilder1();
            director.Construct(builder);
            Product product= builder.GetResult();
            product.Show();
        }
    }
}
