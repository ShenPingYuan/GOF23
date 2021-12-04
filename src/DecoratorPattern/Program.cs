using System;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle=new Circle();
            ShapeDecorator redDecorator = new RedShapeDecorator(circle);
            ShapeDecorator blueDecorator = new BlueShapeDecorator(redDecorator);
            blueDecorator.Draw();
            /*  output:
                draw a circle
                draw a red
                draw a blue
            */
        }
    }
}
