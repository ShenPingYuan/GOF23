using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteAggregate : IAggregate    
    {
        private IList<object> items = new List<object>();
        
        public IIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count => items.Count;
        public object this[int index]
        {
            get => items[index];
            set
            {
                items.Insert(index, value);
            }
        }
    }
}
