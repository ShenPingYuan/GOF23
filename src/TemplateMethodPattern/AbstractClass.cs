using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        public void TemplateMethod()
        {
            Console.WriteLine("TemplateMethod start");
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("TemplateMethod end");
        }
    }
}
