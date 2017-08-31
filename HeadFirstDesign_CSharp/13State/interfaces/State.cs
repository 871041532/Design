using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13State.interfaces
{
    public interface State
    {
        //投入25美分
       void insertQuarter();
        //回退美分
        void ejectQuarter();
        //转动旋钮
        void turnCrank();
        //分配糖果
        void dispense();
    }
}
