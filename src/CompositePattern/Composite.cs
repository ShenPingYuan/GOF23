using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Composite:Component
    {
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+name);
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
