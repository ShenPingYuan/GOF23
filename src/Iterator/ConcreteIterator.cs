using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ConcreteIterator : IIterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public object CurrentItem()
        {
            return aggregate[current];
        }

        public object First()
        {
            return aggregate[0];
        }

        public bool IsDone()
        {
            return current >= aggregate.Count;
        }

        public object Next()
        {
            current++;
            if (current < aggregate.Count)
            {
                return aggregate[current];
            }
            return null;
        }
    }
}
