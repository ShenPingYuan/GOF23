using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class SingletonTwo
    {
        private static volatile SingletonTwo instance;
        private static readonly object syncRoot=new object();
        private SingletonTwo() { }
        public static SingletonTwo GetInstance()
        {
            lock (syncRoot)
            {
                if (instance == null)
                {
                    instance = new SingletonTwo();
                }
            }
            return instance;
        }
    }
}
