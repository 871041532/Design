package Command.implReceiver;
import Command.interfaces.Receiver;

//音响
public class Stereo extends Receiver
{
    @Override
    public void off()
    {
        System.out.println("音响关了。");
    }
    @Override
    public void on()
    {
        System.out.println("音响开了");
    }

    public void setCD()
    {
        System.out.println("插入CD");
    }

    public void setVolume(int volume)
    {
        System.out.println("设置音响音量 " + volume);
    }
}