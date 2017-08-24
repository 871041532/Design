package Observer.impls;

import Observer.interfaces.DisplayElement;
import Observer.interfaces.Observer;

//统计面板
public class StatisticsDispaly implements Observer,DisplayElement
{
    @Override
    public void update(double temp, double humidity, double pressure)
    {
        display();
    }

    @Override
    public void display()
    {
        System.out.println("统计面板显示更新...");
    }
}
