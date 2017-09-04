using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Proxy
{
    public class GumballMonitor
    {
        GumballMachine machine;
        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }
        public void report()
        {
            Console.WriteLine("糖果机当前位置："+machine.getLocation());
            Console.WriteLine("糖果数量："+machine.getCount());
            Console.WriteLine("机器状态："+machine.getState());
        }
    }
}
