using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class ShapeFactory:AbstractFactory
    {
        internal override IShape GetShape<T>()
        {
            Type shapeType = typeof(T);
            IShape shape = null;
            switch (shapeType.Name)
            {
                case nameof(Circle):
                    shape = new Circle();
                    break;
                case nameof(Rectangle):
                    shape = new Rectangle();
                    break;
                case nameof(Square):
                    shape = new Square();
                    break;
                default:
                    break;
            }
            return shape;
        }
        internal override IColor GetColor<T>()
        {
            return null;
        }
    }
}
