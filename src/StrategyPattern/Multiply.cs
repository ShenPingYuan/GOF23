using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Multiply : IStrategy
    {
        public double Caculate(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
