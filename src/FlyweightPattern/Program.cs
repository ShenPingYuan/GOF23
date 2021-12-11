using System;

namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;
            FlyweightFactory factory = new FlyweightFactory();

            IFlyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            IFlyweight fy = factory.GetFlyweight("Y");
            fx.Operation(--extrinsicstate);

            IFlyweight fz = factory.GetFlyweight("Z");
            fx.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight uf=new UnsharedConcreteFlyweight();
            uf.Operation(--extrinsicstate);

            string strA = "a string";
            string strB = "a string";
            Console.WriteLine(string.Equals(strA,strB));
        }
    }
}
