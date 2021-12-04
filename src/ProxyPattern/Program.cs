using System;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();
        }
    }
}
