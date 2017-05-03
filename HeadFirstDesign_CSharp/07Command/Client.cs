using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Command
{
    //客户负责创建一个ConcreteCommand,并设置接收者
    public abstract class Client
    {
    }
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
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
        }
        //设置插槽
        public void setCommand(int slot,Command onCommand,Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        //按下开启按钮
        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].execute();
        }
        //按下关闭按钮
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].execute();
        }
        
        public string toString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n--------Remote Control-----------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot"+i+"]:"+ onCommands[i].GetType().Name+"  "+offCommands[i].GetType().Name);
            }
            return stringBuff.ToString();
        }
    }
}
