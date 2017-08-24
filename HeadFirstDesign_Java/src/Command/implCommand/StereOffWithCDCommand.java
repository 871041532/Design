package Command.implCommand;

import Command.implReceiver.Stereo;
import Command.interfaces.Command;

//音响关
public class StereOffWithCDCommand implements Command
{
    Stereo stereo;

    public StereOffWithCDCommand(Stereo _stereo)
    {
        stereo = _stereo;
    }

    public void execute()
    {
        stereo.off();
    }

    public void undo()
    {
        stereo.on();
        stereo.setCD();
        stereo.setVolume(60);
    }
}