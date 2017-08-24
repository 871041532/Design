package Strategy.behaviorImpl;

import Strategy.behaviorInterface.QuackBehavior;

//吱吱叫
public class Squeak implements QuackBehavior
{
    @Override
    public void quack()
    {
        System.out.println("吱吱叫...");
    }
}
