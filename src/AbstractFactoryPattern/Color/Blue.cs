using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("fill with blue color");
        }
    }
}
