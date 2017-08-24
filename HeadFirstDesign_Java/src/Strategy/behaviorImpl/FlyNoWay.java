package Strategy.behaviorImpl;

import Strategy.behaviorInterface.FlyBehavior;

//不会飞
public class FlyNoWay implements FlyBehavior
{
    @Override
    public void fly()
    {
        System.out.println("其实不会飞...");
    }
}
