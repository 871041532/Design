package Command.implCommand;

import Command.implReceiver.CeilingFanHigh;
import Command.interfaces.Command;

//天花板吊扇低速
public class CeilingFanHighLowCommand implements Command
{
    CeilingFanHigh receiver;
    int preSpeed;

    public CeilingFanHighLowCommand(CeilingFanHigh _receiver)
    {
        receiver = _receiver;
    }

    public void execute()
    {
        preSpeed = receiver.getSpeed();
        receiver.low();
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
