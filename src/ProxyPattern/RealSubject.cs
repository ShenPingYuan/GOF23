using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("a original request");
        }
    }
}
