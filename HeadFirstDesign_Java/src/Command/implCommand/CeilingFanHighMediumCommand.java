package Command.implCommand;

import Command.implReceiver.CeilingFanHigh;
import Command.interfaces.Command;

//天花板吊扇中速
public class CeilingFanHighMediumCommand implements Command
{
    CeilingFanHigh receiver;
    int preSpeed;

    public CeilingFanHighMediumCommand(CeilingFanHigh _receiver)
    {
        receiver = _receiver;
    }

    public void execute()
    {
        preSpeed = receiver.getSpeed();
        receiver.medium();
    }

    public void undo()
    {
        if (preSpeed == CeilingFanHigh.HIGH)
        {
            receiver.high();
        } else if (preSpeed == CeilingFanHigh.MEDIUM)
        {
            receiver.medium();
        } else if (preSpeed == CeilingFanHigh.LOW)
        {
            receiver.low();
        } else if (preSpeed == CeilingFanHigh.OFF)
        {
            receiver.off();
        }
    }
}
