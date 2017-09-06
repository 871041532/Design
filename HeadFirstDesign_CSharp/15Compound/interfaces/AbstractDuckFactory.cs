using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.interfaces
{
    //抽象鸭子工厂
    public abstract class AbstractDuckFactory
    {
        public abstract Quackable createMallardDuck();
        public abstract Quackable createRedHeadDuck();
        public abstract Quackable createDuckCall();
        public abstract Quackable createRubberDuck();
    }
}
