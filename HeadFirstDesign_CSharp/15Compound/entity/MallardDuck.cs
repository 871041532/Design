
using System;
using _15Compound.interfaces;
using _15Compound.entity.observer;

namespace _15Compound.entity
{
    //绿头鸭
    public class MallardDuck : Quackable
    {
        Observable observable;
        public MallardDuck()
        {
            observable = new Observable(this);
        }

        public void notifyObservers()
        {
            observable.notifyObservers();
        }

        public void quack()
        {
            Console.WriteLine("绿头鸭嘎嘎叫...");
            notifyObservers();
        }

        public void registerObserver(Observer observer)
        {
            observable.registerObserver(observer);
        }
    }
}
