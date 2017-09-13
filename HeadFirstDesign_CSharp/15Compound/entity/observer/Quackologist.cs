using _15Compound.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Compound.entity.observer
{
    public class Quackologist : Observer
    {
        public void update(QuackObservable duck)
        {
            Console.WriteLine("监视器："+duck+"鸣叫...");
        }
    }
}
