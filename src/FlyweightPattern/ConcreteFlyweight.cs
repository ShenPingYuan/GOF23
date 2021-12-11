using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class ConcreteFlyweight : IFlyweight
    {
        public void Operation(int extrinsicstate)
        {
            Console.WriteLine($"具体Flyweight:{extrinsicstate}");
        }
    }
}
