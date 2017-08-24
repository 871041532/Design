package Decorator.impl;

import Decorator.inter.Beverage;

public class HouseBlend extends Beverage
{
    public HouseBlend()
    {
        description="HouseBlend coffee";
    }

    @Override
    public double cost()
    {
        return 5.6;
    }
}
