using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ConcreteImplementorB : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine("具体实现B的方法执行");
        }
    }
}
