using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*适配器模式
             * 将一个类的接口，转换成客户期望的另一个接口。适配器让原本接口不兼容的类可以合作无间。
             */

            /*三要素
             * 客户：客户是依据目标接口实现的。（main程序）
             * 适配器：适配器实现了目标接口持有被适配者的实例。
             * 被适配者：（火鸡）
             * 目标：（鸭子）
             */

            /*使用过程
             * 1.客户通过目标接口调用适配器的方法对适配器发出请求。
             * 2.适配器使用被适配者接口把请求转换成被适配者的一个或多个调用接口。
             * 3.客户接收到调用的结果，但并未察觉这一切是适配器在起转换作用。
             */

            /*对象适配器：单继承语言中使用，适配器持有被适配者对象，组合实现。
             * 类适配器：多继承语言中使用，适配器同时继承被适配者和目标类。
             */
            Duck bigDuck = new BigDuck();
            bigDuck.quack();
            bigDuck.fly();

            BigTurkey bigTurkey = new BigTurkey();
            Duck adapter01 = new TurkeyAdapter(bigTurkey);
            adapter01.quack();
            adapter01.fly();
            Console.ReadLine();
        }
    }
}
