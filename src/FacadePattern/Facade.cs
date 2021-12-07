using FacadePattern.SubSystems;
using System;

namespace FacadePattern
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }
        public void MethodA()
        {
            Console.WriteLine("method group A -----");
            one.MethodOne();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("method group B -----");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
