using _15Compound.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity
{
    //嘎嘎统计
    public class QuackCounter : Quackable
    {
        Quackable duck;
        static int numberOfQuacks;
        public void registerObserver(Observer observer) { }
        public void notifyObservers() { }
        public QuackCounter(Quackable duck)
        {
            this.duck = duck;
        }

        public void quack()
        {
            duck.quack();
            ++numberOfQuacks;
        }

        public static int getQuacks()
        {
            return numberOfQuacks;
        }
    }
}
