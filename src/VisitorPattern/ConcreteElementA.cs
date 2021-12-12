using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ConcreteElementA : Element
    {
        //双分派技术
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA() { }
    }
}
