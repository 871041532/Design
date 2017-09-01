using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    public class WinnerState : State
    {
        GumballMachine gumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void dispense()
        {
            Console.WriteLine("恭喜你，获得了双倍糖果...");
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
            else
            {
                gumballMachine.releaseBall();
                if (gumballMachine.getCount()>0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Console.WriteLine("糖果售完辣...");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }
    }
}
