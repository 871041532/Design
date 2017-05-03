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
    public abstract class Pizza {
        protected string name;
        protected Dough dough;//面团基类
        protected Sauce sauce;//酱料基类
        protected Cheese cheese;//起司奶酪基类
        protected ArrayList toppings = new ArrayList();//配料

        public abstract void prepare();//来自原料工厂的抽象类
        public virtual void bake() {
            Console.WriteLine("Bake for 25 miniutes at 350.");
        }
        public virtual void cut() {
            Console.WriteLine("Cutting the pizza into diagonal slices");//对角线切片
        }
        public virtual void box() {//包装
            Console.WriteLine("Place pizza in official PizzaStore box" + "\n");
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public String toString()
        {
            return "这是一个" + name+"风格的披萨。";
        }
    }

    //起司披萨
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public CheesePizza(PizzaIngredientFactory _ingredientFactory)
        {
            ingredientFactory = _ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing "+name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }

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
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (item== PizzaType.cheese)
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");
            }
            else if(item== PizzaType.veggie)
            {
                return null;
            }
            else if (item== PizzaType.clam)
            {
                return null;
            }
            else if (item== PizzaType.pepperoni)
            {
                return null;
            }
            return pizza;
        }
    }

    //芝加哥工厂
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(PizzaType item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new CHPizzaIngredientFactory();
            if (item== PizzaType.cheese)
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza");
            }
            else if (item== PizzaType.veggie)
            {
                return null;
            }
            else if (item== PizzaType.clam)
            {
                return null;
            }
            else if (item== PizzaType.pepperoni)
            {
                return null;
            }
            return pizza;
        }
    }
}
