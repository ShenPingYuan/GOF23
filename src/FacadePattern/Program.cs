﻿using System;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
}
