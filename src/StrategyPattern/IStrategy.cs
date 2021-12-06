using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IStrategy
    {
        public double Caculate(double number1,double number2);
    }
}
