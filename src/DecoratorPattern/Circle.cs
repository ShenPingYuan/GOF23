using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("draw a circle");
        }
    }
}
