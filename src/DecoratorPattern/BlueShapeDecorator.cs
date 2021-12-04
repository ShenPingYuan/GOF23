using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("border color blue");
        }
    }
}
