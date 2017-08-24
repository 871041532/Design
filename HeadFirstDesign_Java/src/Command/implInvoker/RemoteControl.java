package Command.implInvoker;

import Command.interfaces.*;
import Command.implCommand.*;

public class RemoteControl extends Invoker
{
    Command[] onCommands;
    Command[] offCommands;
    Command undoCommand;

    public RemoteControl()
    {
        onCommands = new Command[7];
        offCommands = new Command[7];
        Command noCommand = new NoCommand();
        for (int i = 0; i < 7; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
        undoCommand = new NoCommand();
    }

    //设置插槽
    public void setCommand(int slot, Command onCommand, Command offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    //按下开启按钮
    public void onButtonWasPushed(int slot)
    {
        onCommands[slot].execute();
        undoCommand = onCommands[slot];
    }

    //按下关闭按钮
    public void offButtonWasPushed(int slot)
    {
        offCommands[slot].execute();
        undoCommand = offCommands[slot];
    }

    //按下撤销按钮
    public void undoButtonWasPushed()
    {
        undoCommand.undo();
    }

    public String toString()
    {
        StringBuilder stringBuff = new StringBuilder();
        stringBuff.append("\n--------Remote Control-----------\n");
        for (int i = 0; i < onCommands.length; i++)
        {
            stringBuff.append("[slot" + i + "]:" + onCommands[i].getClass().getName() + "  " + offCommands[i].getClass().getName());
        }
        return stringBuff.toString();
    }
}
