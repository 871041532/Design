package Observer.impls;

import Observer.interfaces.DisplayElement;
import Observer.interfaces.Observer;

//条件面板
public class ConcreteConditionsDisplay implements Observer,DisplayElement
{
    @Override
    public void update(double temp, double humidity, double pressure)
    {
        display();
    }
    @Override
    public void display()
    {
        System.out.println("预报面板显示更新...");
    }
}
