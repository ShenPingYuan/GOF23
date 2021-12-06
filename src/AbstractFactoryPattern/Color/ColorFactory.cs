using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class ColorFactory:AbstractFactory
    {
        internal override IColor GetColor(string type)
        {
            switch (type.ToUpper())
            {
                case "RED":
                    return new Red();
                case "GREEN":
                    return new Green();
                case "BLUE":
                    return new Blue();
                default:
                    break;
            }
            return null;
        }
        internal override IShape GetShape(string type) => null;
    }
}
