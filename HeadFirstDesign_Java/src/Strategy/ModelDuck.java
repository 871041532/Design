package Strategy;

import Strategy.behaviorImpl.FlyNoWay;
import Strategy.behaviorImpl.MuteQuack;

/**
 * Created by zhoukb on 2017/8/24.
 */
public class ModelDuck extends Duck
{
    public ModelDuck()
    {
        flyBehavior=new FlyNoWay();
        quackBehavior=new MuteQuack();
    }
    @Override
    public void display()
    {
        System.out.println("一只模型鸭");
    }
}
