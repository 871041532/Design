package Command.implCommand;

import Command.implReceiver.Stereo;
import Command.interfaces.Command;

//音响开
public class StereOnWithCDCommand implements Command
{
    Stereo stereo;

    public StereOnWithCDCommand(Stereo _stereo)
    {
        stereo = _stereo;
    }

    public void execute()
    {
        stereo.on();
        stereo.setCD();
        stereo.setVolume(60);
    }

    public void undo()
    {
        stereo.off();
    }
}
