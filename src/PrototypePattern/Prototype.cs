using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Prototype
    {
        //some members

        public abstract Prototype Clone();
    }
}
