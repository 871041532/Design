using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Decorator
{
    public abstract class Beverage
    {
        protected string description="Unkown Beverage";
        public virtual void setDescription(string description) { this.description = description; }
        public virtual string getDescription() { return description; }
        public abstract double cost();
    }
    //四种
    class DarkRoast : Beverage
    {
        public DarkRoast() { description = "DarkRoast coffee"; }
        public override double cost()
        {
            return 3.2;
        }
    }
    class HouseBlend : Beverage
    {
        public HouseBlend() { description = "HouseBlend coffee"; }
        public override double cost()
        {
            return 5.65;
        }
    }
    class Espresso : Beverage
    {
        public Espresso() { description = "Espresso coffee"; }
        public override double cost()
        {
            return 1.99;
        }
    }
    class Decaf : Beverage
    {
        public Decaf() { description = "Decaf coffee";}
        public override double cost()
        {
            return 3.45;
        }
    }

    //调味抽象类
    public abstract class CondimentDecorator:Beverage
    {
        public Beverage bevarage;
    }
    //继承
    class Milk : CondimentDecorator
    {     
        public Milk(Beverage bevarage)
        {
            this.bevarage = bevarage;
        }
        public override double cost()
        {
            return 0.20 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + ",Milk";
        }
    }
    class Mocha : CondimentDecorator//摩卡
    {
        public Mocha(Beverage bevarage)
        {
            this.bevarage = bevarage;
        }
        public override double cost()
        {
            return 0.30 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + ",Mocha";
        }
    }
    class Soy : CondimentDecorator//大豆
    {
        public Soy(Beverage bevarage)
        {
            this.bevarage = bevarage;
        }
        public override double cost()
        {
            return 0.40 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + ",Soy";
        }
    }
    class Whlp : CondimentDecorator//奶泡
    {
        public Whlp(Beverage bevarage)
        {
            this.bevarage = bevarage;
        }
        public override double cost()
        {
            return 0.50 + bevarage.cost();
        }

        public override string getDescription()
        {
            return bevarage.getDescription() + ",Whlp";
        }
    }
}
