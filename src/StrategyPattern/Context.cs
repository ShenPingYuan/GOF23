using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public double ExecuteStrategy(double number1,double number2)
        {
            return strategy.Caculate(number1, number2);
        }
    }
}
