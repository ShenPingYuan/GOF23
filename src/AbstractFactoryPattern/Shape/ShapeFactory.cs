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
            switch (typeof(T).Name)
            {
                case nameof(Circle):
                    return new Circle();
                case nameof(Square):
                    return new Square();
                case nameof(Rectangle):
                    return new Rectangle();
                default:
                    break;
            }
            return null;
        }
        internal override IColor GetColor<T>()
        {
            return null;
        }
    }
}
