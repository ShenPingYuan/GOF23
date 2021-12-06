using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClassA = new ConcreteClassA();
            abstractClassA.TemplateMethod();
            Console.WriteLine("--------------------------------");
            AbstractClass abstractClassB = new ConcreteClassB();
            abstractClassB.TemplateMethod();
        }
    }
}
