using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class DivFactory : IFactory
    {
        public IOperation CreateOperation()
        {
            return new DivOperation();
        }
    }
}
