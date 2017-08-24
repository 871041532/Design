package Decorator.impl;

import Decorator.inter.Beverage;
import Decorator.inter.CondimentDecorator;

//摩卡
public class Mocha extends CondimentDecorator
{
    public Mocha(Beverage bevarage)
    {
        this.bevarage = bevarage;
    }
    @Override
    public double cost()
    {
        return 0.30 + bevarage.cost();
    }
    @Override
    public String getDescription()
    {
        return bevarage.getDescription() + ",Mocha";
    }
}