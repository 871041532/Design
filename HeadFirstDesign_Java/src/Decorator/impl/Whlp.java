package Decorator.impl;

import Decorator.inter.Beverage;
import Decorator.inter.CondimentDecorator;

public class Whlp extends CondimentDecorator//奶泡
{
    public Whlp(Beverage bevarage)
    {
        this.bevarage = bevarage;
    }
    @Override
    public double cost()
    {
        return 0.50 + bevarage.cost();
    }
    @Override
    public String getDescription()
    {
        return bevarage.getDescription() + ",Whlp";
    }
}