package Command.implCommand;

import Command.implReceiver.GarageDoor;
import Command.interfaces.Command;

//车库门开
public class GarageDoorOnCommand implements Command
{
    GarageDoor receiver;

    public GarageDoorOnCommand(GarageDoor _receiver)
    {
        receiver = _receiver;
    }

    public void execute()
    {
        receiver.on();
    }

    public void undo()
    {
        receiver.off();
    }
}