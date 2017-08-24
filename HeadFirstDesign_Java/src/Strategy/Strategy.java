package Strategy;

import Strategy.behaviorImpl.FlyRocketPowered;
import Strategy.behaviorImpl.Squeak;

/*策略模式
 定义了算法族，分别封装起来，让它们之间可以互相替换，
 此模式让算法的变化独立于使用算法的客户。
 */
public class Strategy
{
    public static void main(String[] args)
    {
        Duck moduleDuck=new ModelDuck();
        moduleDuck.display();
        moduleDuck.performFly();
        moduleDuck.performQuack();

        moduleDuck.setFlyBehavior(new FlyRocketPowered());
        moduleDuck.setQuackBehavior(new Squeak());
        moduleDuck.performFly();
        moduleDuck.performQuack();
    }
}
