package Observer.impls;

import Observer.interfaces.Observer;
import Observer.interfaces.Subject;

import java.util.ArrayList;

//天气数据Data Subject
public class WeatherDataSubject implements Subject
{
    //观察者列表
    private ArrayList<Observer> observers=new ArrayList<Observer>();
    //温度
    private double temperature;
    //湿度
    private double humidity;
    //压力
    private double pressure;
    //是否通知观察者
    private boolean change;

    //手动设置测量数据
    public void setMeasurements(double temperature,double humidity,double pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        measurementsChanged();
    }

    //改变时调用(外部调用)
    public void measurementsChanged()
    {
        if (change)
        {
            notifyObservers();
        }
    }

    @Override
    public void registerObserver(Observer o)
    {
        observers.add(o);
    }

    @Override
    public void removeObserver(Observer o)
    {
        observers.remove(o);
    }

    @Override
    public void notifyObservers()
    {
        for (Observer item:observers)
        {
            item.update(getTemperature(), getHumidity(), getPressure());
        }
    }

    public void setChange(boolean change)
    {
        this.change = change;
    }

    public double getTemperature()
    {

        return temperature;
    }

    public double getHumidity()
    {
        return humidity;
    }

    public double getPressure()
    {
        return pressure;
    }

    public boolean isChange()
    {
        return change;
    }
}
