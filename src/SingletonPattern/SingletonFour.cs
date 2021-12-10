using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal sealed class SingletonFour
    {
        private static readonly SingletonFour _instance = new SingletonFour();
        private SingletonFour() { }
        public static SingletonFour GetInstance()
        {
            return _instance;
        }
    }
}
