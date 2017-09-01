using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    public abstract class State
    {
        //投入25美分
        public virtual void insertQuarter()
        {
            Console.WriteLine("此时不能投入硬币...");
        }
        //回退美分
        public virtual void ejectQuarter()
        {
            Console.WriteLine("此时不能回退美分...");
        }
        //转动旋钮
        public virtual bool turnCrank()
        {
            Console.WriteLine("此时不能转动曲柄...");
            return false;
        }
        //分配糖果
        public virtual void dispense()
        {
            Console.WriteLine("此时不能分配糖果..");
        }
        //重填
        public virtual void turnRefill()
        {
            Console.WriteLine("此时不能重新装填...");
        }
    }
}
