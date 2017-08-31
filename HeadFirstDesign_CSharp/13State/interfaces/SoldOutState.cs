using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    //售罄状态
    public class SoldOutState : State
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("没有糖果了...");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("没有硬币可退...");
        }

        public void insertQuarter()
        {
            Console.WriteLine("糖果已卖完，请勿投入硬币...");
        }

        public void turnCrank()
        {
            Console.WriteLine("糖果已卖完，我们不能给你糖果...");
        }
    }
}
