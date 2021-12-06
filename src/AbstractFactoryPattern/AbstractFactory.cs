using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        internal abstract IColor GetColor(string type);
        internal abstract IShape GetShape(string type);
    }
}
