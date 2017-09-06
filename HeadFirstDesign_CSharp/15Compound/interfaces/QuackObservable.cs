using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.interfaces
{
    public interface QuackObservable
    {
        void registerObserver(Observer observer);
        void notifyObservers();
    }

    public interface Observer
    {
        void update(QuackObservable duck);
    }
}
