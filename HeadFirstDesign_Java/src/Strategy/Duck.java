package Strategy;

import Strategy.behaviorInterface.FlyBehavior;
import Strategy.behaviorInterface.QuackBehavior;

abstract class Duck
{
    //行为变量被声明为接口
    protected FlyBehavior flyBehavior;
    protected QuackBehavior quackBehavior;

    public void setFlyBehavior(FlyBehavior flyBehavior)
    {
        this.flyBehavior = flyBehavior;
    }

    public void setQuackBehavior(QuackBehavior quackBehavior)
    {
        this.quackBehavior = quackBehavior;
    }
    public void performFly()
    {
        flyBehavior.fly();
    }
    public void performQuack()
    {
        quackBehavior.quack();
    }
    public void display()
    {
        System.out.println("一只普通鸭子");
    }
}
