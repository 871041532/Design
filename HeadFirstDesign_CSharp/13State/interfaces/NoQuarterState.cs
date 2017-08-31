using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    //没有美分的状态
    public class NoQuarterState : State
    {
        GumballMachine gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void dispense()
        {
            Console.WriteLine("如果没给钱，就不能要求糖果...");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("如果没给钱就不能要求退钱...");
        }

        public void insertQuarter()
        {
            Console.WriteLine("投入了一个硬币...");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("如果没给钱就不能要求糖果...");
        }
    }
}
