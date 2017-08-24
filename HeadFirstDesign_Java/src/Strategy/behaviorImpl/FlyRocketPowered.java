package Strategy.behaviorImpl;

import Strategy.behaviorInterface.FlyBehavior;

//火箭动力飞行
public class FlyRocketPowered implements FlyBehavior
{
    @Override
    public void fly()
    {
        System.out.println("使用火箭动力飞行...");
    }
}
