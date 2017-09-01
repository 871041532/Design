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

        public override void turnRefill()
        {
            gumballMachine.refill(10);
        }
    }
}
