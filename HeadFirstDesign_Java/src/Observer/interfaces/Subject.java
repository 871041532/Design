package Observer.interfaces;

//抽象主题
public interface Subject
{
    void registerObserver(Observer o);//注册
    void removeObserver(Observer o);//移除
    void notifyObservers();//通知订阅者
}
