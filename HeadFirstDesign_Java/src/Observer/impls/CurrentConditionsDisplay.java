package Observer.impls;

import Observer.interfaces.DisplayElement;
import Observer.interfaces.Observer;
import Observer.interfaces.Subject;

//当前状况布告板
public class CurrentConditionsDisplay implements Observer,DisplayElement
{
    private double temperature;
    private double humidity;
    private Subject weatherData;

    public CurrentConditionsDisplay(Subject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    @Override
    public void update(double temp, double humidity, double pressure)
    {
        temperature = temp;
        this.humidity = humidity;
        display();
    }

    @Override
    public void display()//显示观测内容
    {
        System.out.println("当前温度："+ temperature+" 当前湿度："+ humidity);
    }
}
