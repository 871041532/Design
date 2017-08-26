using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Template
{
    public abstract class CaffeineBeverage
    {
        //制作过程
        public void prepareRecipe()
        {
            boilWater();//煮水
            brew();//冲泡
            pourInCup();//倒水入杯
            if (customerWantsCondiments())
            {
                addCondiments();//添加佐料
            }           
        }
        public virtual void boilWater()
        {
            Console.WriteLine("煮水...");
        }
        //冲泡
        public abstract void brew();
        public virtual void pourInCup()
        {
            Console.WriteLine("倒水入杯...");
        }
        //添加佐料
        public abstract void addCondiments();

        //钩子函数
        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
