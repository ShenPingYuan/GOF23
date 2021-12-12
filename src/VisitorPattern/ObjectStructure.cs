using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ObjectStructure
    {
        private IList<Element> elements=new List<Element>();
        public void Attach(Element element)=>elements.Add(element);
        public void Detach(Element element)=>elements.Remove(element);
        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
