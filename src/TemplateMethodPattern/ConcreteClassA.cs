using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Implementation of method 1 in concrete class A");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Implementation of method 2 in concrete class A");
        }
    }
}
