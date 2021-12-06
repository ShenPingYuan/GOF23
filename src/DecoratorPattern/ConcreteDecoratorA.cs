using System;
namespace DecoratorPattern
{
    public class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "new state";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}
