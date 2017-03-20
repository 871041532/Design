using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    interface FlyBehavior
    {
       void fly();
    }
    //使用翅膀飞
    class FlyWithWings: FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("使用翅膀飞翔...");
        }
    }
    //不会飞
    class FlyNoWay:FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("其实不会飞...");
        }
    }
    //火箭
    class FlyRocketPowered:FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("使用火箭动力飞行...");
        }
    }
}
