using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class SingletonThree
    {
        private static volatile SingletonThree instance;
        private static readonly object syncRoot = new object();
        private SingletonThree() { }
        public static SingletonThree GetInstance()
        {
            //Double-Check Locking(双检锁/双判断锁)
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThree();
                    }
                }
            }
            return instance;
        }
    }
}
