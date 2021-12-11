using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class UnsharedConcreteFlyweight : IFlyweight
    {
        public void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享的具体flyweight：extrinsicstate");
        }
    }
}
