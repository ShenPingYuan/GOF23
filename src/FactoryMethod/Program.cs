using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new AddFactory();
            IOperation operation = factory.CreateOperation();
            Console.WriteLine(operation.Calculate(2,3));//5
        }
    }
}
