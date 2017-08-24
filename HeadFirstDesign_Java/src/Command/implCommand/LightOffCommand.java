package Command.implCommand;

import Command.implReceiver.Light;
import Command.interfaces.Command;

//灯关
public class LightOffCommand implements Command
{
    Light light;

    public LightOffCommand(Light _light)
    {
        light = _light;
    }

    public void execute()
    {
        light.off();
    }

    public void undo()
    {
        light.on();
    }
}
