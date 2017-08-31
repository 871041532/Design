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

        public void dispense()
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

        public void ejectQuarter()
        {
            Console.WriteLine("sorry没有钱可退...");
        }

        public void insertQuarter()
        {
            Console.WriteLine("糖果出货中，不能投入硬币...");
        }

        public void turnCrank()
        {
            Console.WriteLine("扳两次旋钮不会给你多一个糖果...");
        }
    }
}
