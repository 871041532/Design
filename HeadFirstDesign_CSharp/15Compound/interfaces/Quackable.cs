using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.interfaces
{
    //嘎嘎叫
    public interface Quackable :QuackObservable
    {
        void quack();
    }
}
