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

        public override void insertQuarter()
        {
            Console.WriteLine("投入了一个硬币...");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

    }
}
