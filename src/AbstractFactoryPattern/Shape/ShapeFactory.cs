using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class ShapeFactory:AbstractFactory
    {
        internal override IShape GetShape(string type)
        {
            switch (type.ToUpper())
            {
                case "CIRCLE":
                    return new Circle();
                case "SQUARE":
                    return new Square();
                case "RECTANGLE":
                    return new Rectangle();
                default:
                    break;
            }
            return null;
        }
        internal override IColor GetColor(string type) => null;
    }
}
