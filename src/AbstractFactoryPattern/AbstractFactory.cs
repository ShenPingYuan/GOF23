using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        internal abstract IColor GetColor<T>() where T:IColor;
        internal abstract IShape GetShape<T>() where T:IShape;
    }
}
