using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    public class HasQuarterState : State
    {
        GumballMachine gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("不应该调到这里的...");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("硬币弹出...");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void insertQuarter()
        {
            Console.WriteLine("已有硬币，不能继续投入...");
        }

        public void turnCrank()
        {
            Console.WriteLine("转动了旋柄...");
            gumballMachine.setState(gumballMachine.getSoldState());
        }
    }
}
