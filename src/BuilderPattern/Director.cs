using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Director
    {
        internal void Construct(IBuilder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();
        }
    }
}
