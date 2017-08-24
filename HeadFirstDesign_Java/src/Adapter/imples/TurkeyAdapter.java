package Adapter.imples;

import Adapter.interfaces.Duck;
import Adapter.interfaces.Turkey;

public class TurkeyAdapter implements Duck
{
    Turkey turkey;

    public TurkeyAdapter(Turkey _turkey)
    {
        turkey = _turkey;
    }
    @Override
    public void fly()
    {
        for (int i = 0; i < 5; i++)
        {
            turkey.fly();
        }
    }
    @Override
    public void quack()
    {
        turkey.gobble();
    }
}