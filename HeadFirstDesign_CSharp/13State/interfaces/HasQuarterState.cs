using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    public class HasQuarterState : State
    {
        Random randomWinner = new Random(DateTime.Now.Millisecond);
        GumballMachine gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void ejectQuarter()
        {
            Console.WriteLine("硬币弹出...");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }
        public override bool turnCrank()
        {
            Console.WriteLine("转动了旋柄...");
            int winner = randomWinner.Next(10);
            if (winner==0 && (gumballMachine.getCount()>1))
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldState());
            }
            return true;         
        }
    }
}
