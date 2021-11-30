using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取形状工厂
            AbstractFactory shapeFactory = FactoryProducer.GetFactory<ShapeFactory>();
            //获取Circle的对象
            IShape shape1 = shapeFactory.GetShape<Circle>();
            shape1.Draw();//Draw a Circle
            //获取Rectangle的对象
            IShape shape2 = shapeFactory.GetShape<Rectangle>();
            shape2.Draw();//Draw a Rectangle

            //获取颜色工厂
            AbstractFactory colorFactory = FactoryProducer.GetFactory<ColorFactory>();
            //获取Red的对象
            IColor color1=colorFactory.GetColor<Red>();
            color1.Fill();//fill with red color
            //获取Green的对象
            IColor color2 = colorFactory.GetColor<Green>();
            color2.Fill(); //fill with green color
        }
    }
}
