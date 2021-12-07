using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    internal class AddFactory : IFactory
    {
        public IOperation CreateOperation()
        {
            return new AddOperation();
        }
    }
}
