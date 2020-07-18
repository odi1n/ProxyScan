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
            var proxy = new ProxyScanApi().GetProxy();
            foreach (var prox in proxy)
                Console.WriteLine(prox.ToString());
        }
    }
}
