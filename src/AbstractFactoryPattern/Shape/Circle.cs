using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
}
