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
            switch (typeof(T).Name)
            {
                case nameof(Red):
                    return new Red();
                case nameof(Green):
                    return new Green();
                case nameof(Blue):
                    return new Blue();
                default:
                    break;
            }
            return null;
        }
        internal override IShape GetShape<T>() => null;
    }
}
