﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape decoratedShape;

        protected ShapeDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }
        public virtual void Draw()
        {
            decoratedShape.Draw();
        }
    }
}
