using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class ColorFactory:AbstractFactory
    {
        internal override IColor GetColor<T>()
        {
            Type shapeType = typeof(T);
            IColor color = null;
            switch (shapeType.Name)
            {
                case nameof(Red):
                    color = new Red();
                    break;
                case nameof(Green):
                    color = new Green();
                    break;
                case nameof(Blue):
                    color = new Blue();
                    break;
                default:
                    break;
            }
            return null;
        }
        internal override IShape GetShape<T>() => null;
    }
}
