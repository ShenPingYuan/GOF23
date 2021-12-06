using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class ConcreteBuilder2 : IBuilder
    {
        private Product product=new Product();
        public void BuilderPartA()
        {
            product.Add("part x");
        }

        public void BuilderPartB()
        {
            product.Add("part y");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
