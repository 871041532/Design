package Command.implReceiver;
import Command.interfaces.Receiver;

//天花板吊扇
public class CeilingFanHigh extends Receiver
{
    public static int HIGH = 3;
    public static int MEDIUM = 2;
    public static int LOW = 1;
    public static int OFF = 0;
    String location = "天花板吊扇";
    int speed;

    public CeilingFanHigh(String _location)
    {
        location = _location;
        speed = OFF;
    }

    public void high()
    {
        speed = HIGH;
        System.out.println("天花板吊扇变为高速了");
    }

    public void medium()
    {
        speed = MEDIUM;
        System.out.println("天花板吊扇变为中等转速");
    }

    public void low()
    {
        speed = LOW;
        System.out.println("天花板吊扇变为低转速");
    }

    @Override
    public void off()
    {
        speed = OFF;
        System.out.println("天花板吊扇关了");
    }
    @Override
    public void on()
    {
        high();
    }

    public int getSpeed()
    {
        return speed;
    }
}