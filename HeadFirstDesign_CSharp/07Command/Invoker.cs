using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Command
{
    //调用者持有命令对象并在某个时间点调用excute()方法
    public abstract class Invoker
    {
        public abstract void setCommand(int slot, Command onCommand, Command offCommand);
    }
    public class RemoteControl : Invoker
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
        public override void setCommand(int slot, Command onCommand, Command offCommand)
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

        public string toString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n--------Remote Control-----------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot" + i + "]:" + onCommands[i].GetType().Name + "  " + offCommands[i].GetType().Name);
            }
            return stringBuff.ToString();
        }
    }
}
