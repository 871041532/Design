using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Decorator
{
    public abstract class Beverage
    {
        protected string description="Unkown Beverage";
        public void setDescription(string description) { this.description = description; }
        public string getDescription() { return description; }
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
        public Decaf() { description = "Decaf coffee"; }
        public override double cost()
        {
            return 3.45;
        }
    }
    //调味
    public abstract class CondimentDecorator:Beverage
    {
        public Beverage bevarage;
        public abstract new string getDescription();
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
            return bevarage.getDescription() + ",Mocha";
        }
    }
    class Mocha : CondimentDecorator
    {
        public override double cost()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            throw new NotImplementedException();
        }
    }
    class Soy : CondimentDecorator
    {
        public override double cost()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            throw new NotImplementedException();
        }
    }
    class Whlp : CondimentDecorator
    {
        public override double cost()
        {
            throw new NotImplementedException();
        }

        public override string getDescription()
        {
            throw new NotImplementedException();
        }
    }
}
