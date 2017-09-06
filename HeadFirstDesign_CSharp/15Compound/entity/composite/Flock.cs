using _15Compound.entity.observer;
using _15Compound.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity.composite
{
    public class Flock : Quackable
    {
        List<Quackable> quackers = new List<Quackable>();
        public void registerObserver(Observer observer){}
        public void notifyObservers(){}

        public void add(Quackable quacker)
        {
            quackers.Add(quacker);
        }
        public void quack()
        {
            IEnumerator iterator = quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                Quackable quacker = iterator.Current as Quackable;
                quacker.quack();
            }
        }
    }
}
