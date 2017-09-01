using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    //销售状态
    public class SoldState : State
    {
        GumballMachine gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount()>0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("糖果卖完了...");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }

    }
}
