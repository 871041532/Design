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

        public void dispense()
        {
            throw new NotImplementedException();
        }

        public void ejectQuarter()
        {
            throw new NotImplementedException();
        }

        public void insertQuarter()
        {
            throw new NotImplementedException();
        }

        public void turnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
