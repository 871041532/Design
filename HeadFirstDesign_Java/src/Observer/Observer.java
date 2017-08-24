package Observer;

import Observer.impls.*;

/*观察者模式
 * 定义了对象之间的一对多依赖，这样一来，当一个对象改变状态时，
 * 它的所有依赖者都会受到通知并自动更新
 */

/*松耦合
 * 当两个对象之间松耦合，它们依然可以交互，但是不太清楚彼此的细节。
 * 观察者模式提供了一种对象设计，让主题和观察者之间松耦合。
*/
public class Observer
{
    public static void main(String[] args)
    {
        WeatherDataSubject subject=new WeatherDataSubject();//内部有抽象Observer接口列表，会遍历调用update方法
        CurrentConditionsDisplay observer01=new CurrentConditionsDisplay(subject);

        ConcreteConditionsDisplay observer02=new ConcreteConditionsDisplay();
        subject.registerObserver(observer02);

        ForecastDisplay observer03=new ForecastDisplay();
        subject.registerObserver(observer03);

        StatisticsDispaly observer04=new StatisticsDispaly();
        subject.registerObserver(observer04);

        subject.setChange(true);
        subject.setMeasurements(3.14,5,20);
        subject.setMeasurements(5,15, 18);
        subject.setMeasurements(6, 8, 18);
    }
}
