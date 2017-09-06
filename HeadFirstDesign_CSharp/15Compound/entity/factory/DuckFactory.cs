using _15Compound.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override Quackable createDuckCall()
        {
            return new DuckCall();
        }

        public override Quackable createMallardDuck()
        {
            return new MallardDuck();
        }

        public override Quackable createRedHeadDuck()
        {
            return new RedheadDuck();
        }

        public override Quackable createRubberDuck()
        {
            return new RubberDuck();
        }
    }
}
