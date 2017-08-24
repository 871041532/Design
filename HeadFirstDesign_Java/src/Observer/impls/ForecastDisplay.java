package Observer.impls;

import Observer.interfaces.DisplayElement;
import Observer.interfaces.Observer;

//预报面板
public class ForecastDisplay implements Observer,DisplayElement
{
    @Override
    public void update(double temp, double humidity, double pressure)
    {
        display();
    }

    @Override
    public void display()
    {
        System.out.println("天气预报面板显示更新...");
    }
}
