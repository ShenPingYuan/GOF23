using StatePattern.States;
using System;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}
