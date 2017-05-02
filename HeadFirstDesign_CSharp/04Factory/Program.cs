using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Factory
{
    /*
     * 工厂方法模式定义了一个创建对象的接口，但由子类决定要实例化的类是哪一个。
     * 工厂方法让类把实例化推迟到子类，让子类决定要实例化的类是哪一个。
     * 
     */


    //工厂方法用来处理对象的创建，并将这样的行为封装在子类中。
    //这样，客户程序中关于超类的代码就和子类对象创建代码解耦了。
    //工厂方法创建者与被创建者具有平行的类层级

    //抽象工厂的入口orderPizza，不依赖于特定的Pizza类型，将创建具体Pizza行为放入子工厂中，这样就解耦了
    //抽象工厂PizzaStore中对于对象的每一步生产方法都是可扩展的纯虚函数，如此针对不同工厂作不同扩展
    class Program
    {
        static void Main(string[] args)
        {
            NYPizzaStore nStore = new NYPizzaStore();
            NYStyleCheesePizza np=nStore.orderPizza(PizzaType.cheese) as NYStyleCheesePizza;
            

            ChicagoPizzaStore cStore = new ChicagoPizzaStore();
            ChicagoCheesePizza cc = cStore.orderPizza(PizzaType.cheese) as ChicagoCheesePizza;
            Console.WriteLine("披萨已制作好：" + np.getName());
            Console.WriteLine("披萨已制作好："+cc.getName());
            Console.ReadLine();
        }
    }
}
