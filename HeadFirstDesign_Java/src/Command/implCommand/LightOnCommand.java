package Command.implCommand;

import Command.implReceiver.Light;
import Command.interfaces.Command;

//灯开
public class LightOnCommand implements Command
{
    Light light;

    public LightOnCommand(Light _light)
    {
        light = _light;
    }

    public void execute()
    {
        light.on();
    }

    public void undo()
    {
        light.off();
    }
}
