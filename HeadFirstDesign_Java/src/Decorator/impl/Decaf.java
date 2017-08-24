package Decorator.impl;

import Decorator.inter.Beverage;

//脱咖啡因咖啡
public class Decaf extends Beverage
{
    public Decaf()
    {
        description = "Decaf coffee";
    }

    @Override
    public double cost()
    {
        return 3.45;
    }
}
