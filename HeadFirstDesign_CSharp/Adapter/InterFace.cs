using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public interface Duck
    {
        void quack();
        void fly();
    }
    public interface Turkey
    {
        void gobble();
        void fly();
    }
    public class BigDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("飞出去5米");
        }

        public void quack()
        {
            Console.WriteLine("呱呱叫");
        }
    }
    public class BigTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine("飞出去一米");
        }

        public void gobble()
        {
            Console.WriteLine("咯咯叫");
        }
    }

    public class TurkeyAdapter : Duck
    {
        Turkey turkey;
        public TurkeyAdapter(Turkey _turkey)
        {
            turkey = _turkey;
        }
        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }
        public void quack()
        {
            turkey.gobble();
        }
    }
}
