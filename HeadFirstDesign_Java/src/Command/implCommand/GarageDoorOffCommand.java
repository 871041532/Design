package Command.implCommand;
import Command.implReceiver.GarageDoor;
import Command.interfaces.Command;

//车库门关
public class GarageDoorOffCommand implements Command
{
    GarageDoor receiver;

    public GarageDoorOffCommand(GarageDoor _receive)
    {
        receiver = _receive;
    }

    public void execute()
    {
        receiver.off();
    }

    public void undo()
    {
        receiver.on();
    }
}
