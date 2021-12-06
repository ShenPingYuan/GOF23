using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class ConcreteBuilder1 : IBuilder
    {
        private Product product=new Product();
        public void BuilderPartA()
        {
            product.Add("part A");
        }

        public void BuilderPartB()
        {
            product.Add("part B");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
