using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class SubOperation : IOperation
    {
        public double Calculate(double x, double y)
        {
            return x - y;
        }
    }
}
