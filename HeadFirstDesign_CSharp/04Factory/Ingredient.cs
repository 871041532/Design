using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Factory
{
    public class Dough//面团
    {}
    public class Sauce//酱
    {
    }
    public class Cheese
    {

    }
    public class Vegies//蔬菜
    {

    }
    public class Pepperoni//意大利味香肠
    {

    }
    public class Clams//蚌
    {

    }
    public interface PizzaIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
        Vegies[] createVeggies();
        Pepperoni createPepperoni();
        Clams createClam();
    }

    //纽约原料工厂
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new Cheese();
        }

        public Clams createClam()
        {
            return new Clams();
        }

        public Dough createDough()
        {
            return new Dough();
        }

        public Pepperoni createPepperoni()
        {
            return new Pepperoni();
        }

        public Sauce createSauce()
        {
            return new Sauce();
        }

        public Vegies[] createVeggies()
        {
            Vegies[] temp = new Vegies[3]{new Vegies(),new Vegies(),new Vegies() };
            return temp;
        }
    }

    //芝加哥原料工厂
    public class CHPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new Cheese();
        }

        public Clams createClam()
        {
            return new Clams();
        }

        public Dough createDough()
        {
            return new Dough();
        }

        public Pepperoni createPepperoni()
        {
            return new Pepperoni();
        }

        public Sauce createSauce()
        {
            return new Sauce();
        }

        public Vegies[] createVeggies()
        {
            Vegies[] temp = new Vegies[3] { new Vegies(), new Vegies(), new Vegies() };
            return temp;
        }
    }
}
