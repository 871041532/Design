using _15Compound.entity;
using _15Compound.entity.observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.interfaces
{
    public class GooseAdapter : Quackable
    {
        Goose goose;
        Observable observable;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
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
            goose.honk();
            notifyObservers();
        }
    }
}
