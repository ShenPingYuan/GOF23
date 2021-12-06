using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Divide : IStrategy
    {
        public double Caculate(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException("Divisor cannot be 0");
            }
            return number1 / number2;
        }
    }
}
