using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Duck
    {
        //行为变量被声明为接口类型
        protected FlyBehavior _flyBehavior;
        protected QuackBehavior _quackBehavior;
        //嘎嘎叫
        public void setQuackBehavior(QuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }
        public void performQuack()
        {
            _quackBehavior.quack();
        }
        //飞
        public void setFlyBehavior(FlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }
        public void performFly()
        {
            _flyBehavior.fly();
        }
        //外观
        public virtual void display()
        {
            Console.WriteLine("一只普通鸭子...");
        }
    }
    //模型鸭
    class ModelDuck:Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }
        public override void display()
        {
            Console.WriteLine("一只模型鸭...");
        }
    }
}
