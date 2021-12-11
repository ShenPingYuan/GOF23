using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NotTerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
        }
    }
}
