using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Component
    {
        protected string name;

        protected Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }
}
