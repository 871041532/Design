package Decorator.impl;

import Decorator.inter.Beverage;

//浓咖啡
public class Espresso extends Beverage
{
    public Espresso()
    {
        description="Espresso coffee";
    }

    @Override
    public double cost()
    {
        return 1.99;
    }
}
