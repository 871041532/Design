using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine machine = new GumballMachine("上海",30);
            GumballMonitor monitor = new GumballMonitor(machine);
            monitor.report();
            Console.ReadLine();
        }
    }
}
