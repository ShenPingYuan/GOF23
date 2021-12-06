using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DivOperation : IOperation
    {
        public double Calculate(double x, double y)
        {
            if (y == 0.0)
            {
                Console.WriteLine("divisor cannot be 0");
            }
            return x / y;
        }
    }
}
