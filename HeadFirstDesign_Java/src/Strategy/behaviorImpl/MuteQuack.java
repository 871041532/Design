package Strategy.behaviorImpl;

import Strategy.behaviorInterface.QuackBehavior;

//不会叫
public class MuteQuack implements QuackBehavior
{
    @Override
    public void quack()
    {
        System.out.println("其实不会叫...");
    }
}
