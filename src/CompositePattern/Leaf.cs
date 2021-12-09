using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            Console.WriteLine("cannot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("cannot remove from a leaf");
        }
    }
}
