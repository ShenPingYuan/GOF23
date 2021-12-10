using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ConcreteImplementorA : IImplementor
    {
        public void Operation()
        {
            Console.WriteLine("具体实现A的方法执行");
        }
    }
}
