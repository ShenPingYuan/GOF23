using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("fill with green color");
        }
    }
}
