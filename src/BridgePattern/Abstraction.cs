using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Abstraction
    {
        protected IImplementor implementor;

        public void SetImplementor(IImplementor implementor)
        {
            this.implementor = implementor;
        }
        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
