using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Factory
{

    /*原则
     * 依赖倒置原则：要依赖抽象，不要依赖具体类
     * 不能让高层组件依赖底层组件，而且不管是高层或底层组件，两者都应该依赖抽象。
     * 倒置体现在思维不从顶端Pizza开始向下，而是从底层抽象Pizza开始，向上。
     */

    /*指导方针
     * 变量不可以持有具体类的引用
     * 不要让类派生自具体类
     * 不要覆盖基类中已实现的方法
    */

    /*解析
     * （宁可扩展类，而不修改类：针对接口编程，而不针对实现编程）
     * 工厂方法模式定义了一个创建对象的接口，但由子类决定要实例化的类是哪一个。
     * 工厂方法让类把实例化推迟到子类，让子类决定要实例化的类是哪一个。 
     */

    /*工厂方法
     * 工厂方法用来处理对象的创建，并将这样的行为封装在子类中。
     * 这样，客户程序中关于超类的代码就和子类对象创建代码解耦了。
     * 工厂方法创建者与被创建者具有平行的类层级。
     * 工厂的入口orderPizza，不依赖于特定的Pizza类型，将创建具体Pizza行为放入子工厂中，这样就解耦了
     * 工厂PizzaStore中对于对象的每一步生产方法都是可扩展的纯虚函数，如此针对不同工厂作不同扩展
     */
    
     /*抽象工厂
      * 提供一个接口，用于创建相关或依赖对象的家族，而不需要明确指定具体类。
      * 抽象工厂定义了一个接口，所有的具体工厂都必须实现此接口，这个接口包含一组方法用来生产产品。
     */

    /*异同
     * 当需要创建产品家族和想让制造的相关产品集合起来时，可以使用抽象工厂。（增加接口麻烦）
     * 需要把客户代码从需要实例化的具体类中解耦，或者目前还不知道将来需要实例化哪些具体类时使用工厂方法。（继承子类，实现工厂方法）
     */
    class Program
    {
        static void Main(string[] args)
        {
            NYPizzaStore nStore = new NYPizzaStore();
            Pizza np=nStore.orderPizza(PizzaType.cheese);
            

            ChicagoPizzaStore cStore = new ChicagoPizzaStore();
            Pizza cc = cStore.orderPizza(PizzaType.cheese);
            Console.WriteLine("披萨已制作好：" + np.getName());
            Console.WriteLine("披萨已制作好："+cc.getName());
            Console.ReadLine();
        }
    }
}
