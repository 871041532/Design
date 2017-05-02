using System;
using System.Collections;
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
        protected string name;
        protected string dough;//面团
        protected string sauce;//酱料
        protected ArrayList toppings = new ArrayList();//配料

        public virtual void prepare() {
            Console.WriteLine("Preparing:"+name);
            Console.WriteLine("Tossing dough:"+dough);
            Console.WriteLine("Adding sauce..."+sauce);
            StringBuilder temp = new StringBuilder();
            foreach (var item in toppings)
            {
                temp.Append((" " + item) as string);
            }
            Console.WriteLine("Adding toppings:"+ temp);
        }
        public virtual void bake() {
            Console.WriteLine("Bake for 25 miniutes at 350.");
        }
        public virtual void cut() {
            Console.WriteLine("Cutting the pizza into diagonal slices");//对角线切片
        }
        public virtual void box() {//包装
            Console.WriteLine("Place pizza in official PizzaStore box" + "\n");
        }
        public virtual string getName()
        {
            return name;
        }
    }
    //纽约风格比萨
    public class NYStyleCheesePizza:Pizza{
        public NYStyleCheesePizza() {
            name=("NYStyle风格披萨");
            dough = "薄面";
            sauce = "大蒜酱";
            toppings.Add("碎乳酪作料");
        }
    }
    public class NYStyleVeggiePizza:Pizza{
    }
    public class NYStyleClamPizza:Pizza{}
    public class NYStylePepperoni:Pizza{}
    //芝加哥风格比萨
    public class ChicagoCheesePizza : Pizza {
        public ChicagoCheesePizza()
        {
            name = ("Chicago风格披萨");
            dough = "厚面";
            sauce = "番茄酱";
            toppings.Add("肉干");
        }
    }
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
