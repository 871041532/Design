using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Observer
{
    //抽象主题
    interface Subject
    {
        void registerObserver(Observer o);//注册
        void removeObserver(Observer o);//移除
        void notifyObservers();//通知订阅者
    }
    class WeatherData : Subject
    {
        private ArrayList observers=new ArrayList();//观察者
        private double temperature;//温度
        private double humidity;//湿度
        private double pressure;//压力
        private bool change;//是否通知观察者

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
        public void notifyObservers()
        {
            foreach (Observer item in observers)
            {
                item.update(getTemperature(), getHumidity(), getPressure());
            }
        }
        //改变时是否通知
        public bool isChanged()
        {
            return change;
        }
        //设置通知
        public void setChanged(bool isChange)
        {
            change = isChange;
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
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
    }
}
