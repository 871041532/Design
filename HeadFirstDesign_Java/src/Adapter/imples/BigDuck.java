package Adapter.imples;

import Adapter.interfaces.Duck;

public class BigDuck implements Duck
{
    @Override
    public void fly()
    {
        System.out.println("飞出去5米");
    }
    @Override
    public void quack()
    {
        System.out.println("呱呱叫");
    }
}