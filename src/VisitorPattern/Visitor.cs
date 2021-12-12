using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}
