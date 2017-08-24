using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Observer
{
    //抽象观察者
    interface Observer
    {
        void update(double temp,double humidity,double pressure);//更新
    }
    //抽象显示
    interface DisplayElement
    {
        void display();
    }

    //条件面板
    class ConcreteConditionsDisplay:Observer, DisplayElement
    {
        public void update(double temp, double humidity, double pressure) { }
        public void display() {//显示当前观测值
        }
    }

    //统计面板
    class StatisticsDispaly : Observer, DisplayElement
    {
        public void update(double temp, double humidity, double pressure) { }
        public void display()//显示当前观测值
        {
        }
    }
    //当前状况布告板
    class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private double temperature;
        private double humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void update(double temp, double humidity, double pressure) {
            temperature = temp;
            this.humidity = humidity;
            display();
        }
        public void display()//基于观测值的其他内容
        {
            Console.WriteLine("当前温度："+ temperature+" 当前湿度："+ humidity);
        }
    }
    //预报面板
    class Forecast : Observer, DisplayElement
    {
        public void update(double temp, double humidity, double pressure) { }
        public void display()//显示天气预报
        {
        }
    }
}
