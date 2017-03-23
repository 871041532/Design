using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*观察者模式
             * 定义了对象之间的一对多依赖，这样一来，当一个对象改变状态时，
             * 它的所有依赖者都会受到通知并自动更新
             */
            /*松耦合
             * 当两个对象之间松耦合，它们依然可以交互，但是不太清楚彼此的细节。
             * 观察者模式提供了一种对象设计，让主题和观察者之间松耦合。
            */
            var subject = new WeatherData();//内部有抽象Observer列表，会遍历调用update方法
            var current01 = new CurrentConditionsDisplay(subject);//内部持有subject抽象基类，并将自身加添进去。
            var current02 = new CurrentConditionsDisplay(subject);
            var current03 = new CurrentConditionsDisplay(subject);
            var current04 = new CurrentConditionsDisplay(subject);
            var current05 = new CurrentConditionsDisplay(subject);
            subject.setMeasurements(3.14,5,20);
            subject.setMeasurements(5,15, 18);
            subject.setMeasurements(6, 8, 18);
            Console.ReadLine();
        }
    }
}
