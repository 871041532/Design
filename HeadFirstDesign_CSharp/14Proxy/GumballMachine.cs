using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Proxy
{
    public class GumballMachine
    {
        string location;
        int count;
        public GumballMachine(string location,int count)
        {
            this.count = count;
            this.location = location;
        }
        public int getCount()
        {
            return this.count;
        }
        public string getLocation()
        {
            return this.location;
        }
        public string getState()
        {
            return "糖果机状态很好...";
        }
    }
}
