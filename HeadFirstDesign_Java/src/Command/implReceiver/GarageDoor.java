package Command.implReceiver;
import Command.interfaces.Receiver;

//车库门
public class GarageDoor extends Receiver
{
    @Override
    public void off()
    {
        System.out.println("车库门关了");
    }

    @Override
    public void on()
    {
        System.out.println("车库门开了");
    }
}
