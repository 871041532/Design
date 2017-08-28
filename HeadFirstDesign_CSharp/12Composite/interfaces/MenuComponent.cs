using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Composite.interfaces
{
    public abstract class MenuComponent
    {
        //添加
        public virtual void add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        //移除
        public virtual void remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        //获得child
        public virtual MenuComponent getChild(int i)
        {
            throw new NotImplementedException();
        }
        public virtual string getName()
        {
            throw new NotImplementedException();
        }
        public virtual string getDescription()
        {
            throw new NotImplementedException();
        }
        public virtual double getPrice()
        {
            throw new NotImplementedException();
        }
        public virtual bool isVegetarian()
        {
            throw new NotImplementedException();
        }
        public virtual void print()
        {
            throw new NotImplementedException();
        }
    }
}
