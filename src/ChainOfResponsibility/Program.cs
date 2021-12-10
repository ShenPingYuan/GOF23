using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handlerA = new ConcreteHandlerA();
            Handler handlerB = new ConcreteHandlerB();
            Handler handlerC = new ConcreteHandlerC();

            handlerA.SetSuccessor(handlerB);
            handlerB.SetSuccessor(handlerC);

            int[] requests = new int[] { 1, 2, 4, 6, 7, 8, 12, 12, 14, 22, 4, 25, 46, 34, 45 };
            foreach (int request in requests)
            {
                handlerA.HandleRequest(request);
            }
        }
    }
}
