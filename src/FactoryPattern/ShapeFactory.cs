using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ShapeFactory
    {
        public IShape GetShap(string type)
        {
            switch (type.ToUpper())
            {
                case "CIRCLE":
                    return new Circle();
                case "RECTANGLE":
                    return new Rectangle();
                case "SQUARE":
                    return new Square();
                default:
                    break;
            }
            return null;
        }
    }
}
