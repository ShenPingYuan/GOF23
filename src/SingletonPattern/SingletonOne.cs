using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class SingletonOne
    {
        private static SingletonOne instance;
        private SingletonOne() { }
        public static SingletonOne GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonOne();
            }
            return instance;
        }
    }
}
