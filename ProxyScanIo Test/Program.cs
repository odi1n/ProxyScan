using Leaf.xNet;
using ProxyScanIo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyScanIo_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxyScan = new ProxyScanApi();
            var proxy = proxyScan.GetProxy(type:ProxyType.Socks4, limit:5);
            foreach (var prox in proxy)
                Console.WriteLine(prox.ToString());
        }
    }
}
