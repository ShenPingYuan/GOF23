using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AddOperation : IOperation
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}
