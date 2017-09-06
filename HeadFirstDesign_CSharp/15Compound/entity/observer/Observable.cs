using _15Compound.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity.observer
{
    public class Observable : QuackObservable
    {
        ArrayList observers = new ArrayList();
        QuackObservable duck;

        public Observable(QuackObservable duck)
        {
            this.duck = duck;
        }

        public void notifyObservers()
        {
            IEnumerator iterator = observers.GetEnumerator();
            while (iterator.MoveNext())
            {
                Observer observer = (Observer)iterator.Current;
                observer.update(duck);
            }
        }

        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }
    }
}
