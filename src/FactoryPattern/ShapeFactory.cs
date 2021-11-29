using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ShapeFactory
    {
        public IShape GetShape<T>() where T:IShape
        {
            switch (typeof(T).Name)
            {
                case nameof(Circle):
                    return new Circle();
                case nameof(Rectangle):
                    return new Rectangle();
                case nameof(Square):
                    return new Square();
                default:
                    break;
            }
            return null;
        }
    }
}
