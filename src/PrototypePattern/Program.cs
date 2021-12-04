using System;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype a = new ConcretePrototype("michael shen", 23);
            Console.WriteLine($"a.Name:{a.Name},a.Id:{a.Id}");
            var b = a;
            b.Name = "pingyuan";
            b.Id = 22;
            Console.WriteLine($"a.Name:{a.Name},a.Id:{a.Id}");
            Console.WriteLine($"b.Name:{b.Name},b.Id:{b.Id}");
            //by clone(prototype)
            ConcretePrototype c = (ConcretePrototype)b.Clone();
            c.Name = "shenpingyuan";
            c.Id = 18; 
            Console.WriteLine($"b.Name:{b.Name},b.Id:{b.Id}");
            Console.WriteLine($"c.Name:{c.Name},c.Id:{c.Id}");
        }
    }
}
