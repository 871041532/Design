using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Factory
{
    //比萨类型
   public enum PizzaType
    {
        cheese,//奶酪
        veggie,//植物蛋白
        clam,//蚌蛤
        pepperoni,//意大利辣味香肠
    }
    //比萨基类
    public class Pizza {
        public void prepare() { }
        public void bake() { }
        public void cut() { }
        public void box() { }
    }
    //纽约风格比萨
    public class NYStyleCheesePizza:Pizza{
        public NYStyleCheesePizza() {
            Console.WriteLine("生产了一个NYStyle风格披萨");
        }
    }
    public class NYStyleVeggiePizza:Pizza{}
    public class NYStyleClamPizza:Pizza{}
    public class NYStylePepperoni:Pizza{}
    //芝加哥风格比萨
    public class ChicagoCheesePizza : Pizza { }
    public class ChicagoVegiePizza : Pizza { }
    public class ChicagoClamPizza : Pizza { }
    public class ChicagoPepperoinPizza : Pizza { }

    //抽象工厂
    public abstract class PizzaStore
    {
        public Pizza orderPizza(PizzaType type)
        {
            Pizza pizza;
            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
        protected abstract Pizza createPizza(PizzaType type);
    }

    //纽约工厂
    public class NYPizzaStore:PizzaStore
    {
        protected override Pizza createPizza(PizzaType item)
        {
            if (item== PizzaType.cheese)
            {
                return new NYStyleCheesePizza();
            }
            else if(item== PizzaType.veggie)
            {
                return new NYStyleVeggiePizza();
            }
            else if (item== PizzaType.clam)
            {
                return new NYStyleClamPizza();
            }
            else if (item== PizzaType.pepperoni)
            {
                return new NYStylePepperoni();
            }
            return null;
        }
    }

    //芝加哥工厂
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(PizzaType item)
        {
            if (item== PizzaType.cheese)
            {
                return new ChicagoCheesePizza();
            }
            else if (item== PizzaType.veggie)
            {
                return new ChicagoVegiePizza();
            }
            else if (item== PizzaType.clam)
            {
                return new ChicagoClamPizza();
            }
            else if (item== PizzaType.pepperoni)
            {
                return new ChicagoPepperoinPizza();
            }
            return null;
        }
    }
}
