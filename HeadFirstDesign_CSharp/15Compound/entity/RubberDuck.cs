using _15Compound.entity.observer;
using _15Compound.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity
{
    public class RubberDuck : Quackable
    {
        Observable observable;
        public RubberDuck()
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
            Console.WriteLine("橡皮鸭嘎嘎叫...");
            notifyObservers();
        }
    }
}
