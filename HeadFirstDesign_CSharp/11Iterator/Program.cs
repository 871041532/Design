using _11Iterator.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Iterator
{
    class Program
    {
        /*迭代器模式
         * 迭代器模式提供一种方法顺序访问一个聚合对象中的各个元素，而又不暴露其内部的表示。
         * 
         * 特点：迭代器模式让我们能游走于集合内的每一个元素，而又不暴露其内部的表示。把游走的任务放在迭代器上，而不是在聚合上。这样简化了聚合的接口和实现，也让责任各得其所。
         * 
         * 好处：有一个共同的接口供所有的聚合使用，这对客户代码是很方便呢的，将客户代码从聚合对象的实现解耦了。（Waitress从两种菜单中解耦）
         * 
         * 
         * 单一责任原则
         * 一个类应该只有一个引起变化的原因。
         * 类的每个责任都有改变的潜在区域。超过一个责任，意味着超过一个改变的区域。尽量让每个类保持单一责任。（例子：不应该让两个菜单类自己实现操作遍历的方法）
         * 
         * 
         * 内聚
         * 用来衡量一个类或模块紧密地达到单一目的或责任。
         * 当一个模块或一个类被设计成只支持一组相关的功能时，我们说它具有高内聚；反之，当被设计成支持一组不相关的功能时，我们说它具有低内聚。
         * 内聚是一个比单一责任原则更普遍的概念，但链能够着其实关系是很密切的。遵守这个原则的类容易具有很高的凝聚力，而且比背负许多责任的低内聚类更容易维护。
         */
        static void Main(string[] args)
        {
            DinerMenu dinerMenu = new DinerMenu();
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            CafeMenu cafeMenu = new CafeMenu();

            Waitress alice = new Waitress(pancakeHouseMenu,dinerMenu, cafeMenu);
            alice.printMenu();

            Console.ReadLine();
        }
    }
}
