package Decorator.impl;

import Decorator.inter.Beverage;

//黑咖啡
public class DarkRoast extends Beverage
{
    public DarkRoast()
    {
        description = "DarkRoast coffee";
    }

    @Override
    public double cost()
    {
        return 3.2;
    }
}
