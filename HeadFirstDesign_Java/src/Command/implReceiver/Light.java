package Command.implReceiver;

import Command.interfaces.Receiver;

//灯
public class Light extends Receiver
{
    @Override
    public void off()
    {
        System.out.println("灯关了。");
    }

    @Override
    public void on()
    {
        System.out.println("灯开了。");
    }
}