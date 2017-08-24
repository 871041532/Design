package Decorator.impl;

import Decorator.inter.Beverage;
import Decorator.inter.CondimentDecorator;

public class Soy extends CondimentDecorator//大豆
{
    public Soy(Beverage bevarage)
    {
        this.bevarage = bevarage;
    }
    @Override
    public double cost()
    {
        return 0.40 + bevarage.cost();
    }
    @Override
    public String getDescription()
    {
        return bevarage.getDescription() + ",Soy";
    }
}