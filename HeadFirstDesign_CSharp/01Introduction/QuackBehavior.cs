using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    interface QuackBehavior
    {
        void quack();
    }
    //嘎嘎叫
    class Quack:QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("嘎嘎叫...");
        }
    }
    //吱吱叫
    class Squeak:QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("吱吱叫..");
        }
    }
    //不会叫
    class MuteQuack:QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("其实不会叫...");
        }
    }
}
