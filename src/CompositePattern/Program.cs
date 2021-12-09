using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("leaf A"));
            root.Add(new Leaf("leaf B"));

            Composite comp = new Composite("composite X");
            comp.Add(new Leaf("leaf XA"));
            comp.Add(new Leaf("leaf XB"));
            root.Add(comp);

            Composite comp2 = new Composite("composite XY");
            comp2.Add(new Leaf("leaf XYA"));
            comp2.Add(new Leaf("leaf XYB"));
            comp.Add(comp2);

            root.Add(new Leaf("leaf C"));
            Leaf leafD = new Leaf("leaf D");
            root.Add(leafD);

            root.Display(1);
            root.Remove(leafD);
            root.Display(1);
        }
    }
}
