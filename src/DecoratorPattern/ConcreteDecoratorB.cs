using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class ConcreteDecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("装饰器B进行一些装饰操作");
        }
        private void AddedBehavior()
        {
            //装饰器B的一些操作
        }
    }
}
