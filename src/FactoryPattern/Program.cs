using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape = shapeFactory.GetShap("Square");
            shape.Draw();//Draw a Square

            IShape shape2 = shapeFactory.GetShap("Circle");
            shape2.Draw();//Draw a Circle

            IShape shape3 = shapeFactory.GetShap("Rectangle");
            shape3.Draw();//Draw a Rectangle
        }
    }
}
