package Strategy.behaviorImpl;

import Strategy.behaviorInterface.FlyBehavior;

//飞行方式之使用翅膀飞
public class FlyWithWings implements FlyBehavior
{
    @Override
    public void fly()
    {
        System.out.println("使用翅膀飞翔...");
    }
}
