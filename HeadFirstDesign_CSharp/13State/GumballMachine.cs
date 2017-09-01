using _13State.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State
{
    public class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state;
        int count = 0;

        public GumballMachine(int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            state = soldOutState;
            this.count = count;
            if (count>0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }
        //投入美分
        public void insertQuarter()
        {
            state.insertQuarter();
        }
        //退回美分
        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        //转动曲柄
        public void turnCrank()
        {
            bool isDispense=state.turnCrank();
            if (isDispense)
            {
                state.dispense();
            }           
        }
        //转化为String
        public string toString()
        {
            return "糖果机当前状态：" + state + "  糖果剩余数量：" + count;
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("释放糖果...");
            if (count != 0)
            {
                count -= 1;
            }
        }
        public void turnRefill()
        {
            state.turnRefill();
        }
        public void refill(int count)
        {
            Console.WriteLine("开始重新装填");
            this.count = count;
            if (count > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public State getSoldOutState()
        {
            return soldOutState;
        }
        public State getNoQuarterState()
        {
            return noQuarterState;
        }
        public State getSoldState()
        {
            return soldState;
        }
        public State getHasQuarterState()
        {
            return hasQuarterState;
        }
        public State getWinnerState()
        {
            return winnerState;
        }
        public int getCount()
        {
            return count;
        }
    }
}
