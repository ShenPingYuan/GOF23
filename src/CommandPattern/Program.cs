using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker invoker = new Invoker();
            invoker.SetCommand(c);
            invoker.ExecuteCommand();
        }
    }
}
