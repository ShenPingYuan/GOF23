using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Square");
        }
    }
}
