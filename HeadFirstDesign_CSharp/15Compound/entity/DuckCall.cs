using _15Compound.entity.observer;
using _15Compound.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity
{
    //鸭鸣器
    public class DuckCall : Quackable
    {
        Observable observable;
        public DuckCall()
        {
            observable = new Observable(this);
        }
        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }
        public void notifyObservers()
        {
            observable.notifyObservers();
        }
        public void quack()
        {
            Console.WriteLine("鸭鸣器嘎嘎叫...");
            notifyObservers();
        }
    }
}
