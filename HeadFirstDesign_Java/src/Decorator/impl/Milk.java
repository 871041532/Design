package Decorator.impl;

import Decorator.inter.Beverage;
import Decorator.inter.CondimentDecorator;

//牛奶
public class Milk extends CondimentDecorator
{
    public Milk(Beverage beverage)
    {
        this.bevarage=beverage;
    }

    @Override
    public double cost()
    {
        return 0;
    }
    @Override
    public String getDescription()
    {
        return bevarage.getDescription() + ",Milk";
    }
}
