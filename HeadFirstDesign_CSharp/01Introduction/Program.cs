using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*策略模式
             定义了算法族，分别封装起来，让它们之间可以互相替换，
             此模式让算法的变化独立于使用算法的客户。
             */
            var moduleDuck = new ModelDuck();
            moduleDuck.display();
            moduleDuck.performFly();
            moduleDuck.performQuack();
            moduleDuck.setFlyBehavior(new FlyRocketPowered());
            moduleDuck.setQuackBehavior(new Squeak());
            moduleDuck.performFly();
            moduleDuck.performQuack();
            Console.ReadLine();
        }
    }
}
