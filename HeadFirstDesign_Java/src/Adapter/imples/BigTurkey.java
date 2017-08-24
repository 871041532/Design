package Adapter.imples;

import Adapter.interfaces.Turkey;

public class BigTurkey implements Turkey
{
    @Override
    public void fly()
    {
        System.out.println("飞出去一米");
    }

    @Override
    public void gobble()
    {
        System.out.println("咯咯叫");
    }
}