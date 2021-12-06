using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal interface IBuilder
    {
        void BuilderPartA();
        void BuilderPartB();
        Product GetResult();
    }
}
