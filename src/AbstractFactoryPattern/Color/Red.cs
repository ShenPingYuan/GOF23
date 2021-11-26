using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("fill with red color");
        }
    }
}
