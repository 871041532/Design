using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Command
{
    class Program
    {
        static void Main(string[] args)
        {
            /*命令模式
             * 将“请求”封装成对象，以便使用不同的请求、队列或者日志来参数化其他对象。
             * 命令模式也支持可撤销的操作。
             * 命令模式将发出请求的对象和执行请求的对象解耦。
             * 在被解耦的两者之间是通过命令对象进行沟通的，命令对象封装了接收者和一个或一组动作。
             */

            /*用途：队列请求（GameBox中间件，task系统）
             * 在某一端添加命令，然后另一端则是线程。工作队列类和进行计算的对象之间完全是解耦的。
             * 线程进行下面的动作：从队列中取出一个命令，调用它的execute方法，等待这个调用完成，然后将此命令丢弃，再取出下一个命令。
            */

            /*用途：日志请求
             * 当执行命令的时候，将历史记录存储在磁盘中，一旦司机就将命令对象重新加载，并成批地依次调用这些对象的execute()方法
             * 对于更高级的应用，技巧被扩展应用到事务处理中，也就是说一整群操作必须全部完成，或者没有进行任何的操作。
             */
             //Client
            RemoteControl remoteControl = new RemoteControl();

            //Receiver
            Light light = new Light();
            CeilingFanHigh ceilingFanHigh = new CeilingFanHigh();
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo();

            //Command
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            CeilingFanHighOnCommand ceilingFanHignOnCommand = new CeilingFanHighOnCommand(ceilingFanHigh);
            CeilingFanHighOffCommand ceilingFanHighOffCommand = new CeilingFanHighOffCommand(ceilingFanHigh);
            GarageDoorOnCommand garaDoorOnCommand = new GarageDoorOnCommand(garageDoor);
            GarageDoorOffCommand garaDoorOffCommand = new GarageDoorOffCommand(garageDoor);
            StereOnWithCDCommand stereOnWithCDCommand = new StereOnWithCDCommand(stereo);
            StereOffWithCDCommand stereOffWithCDCommand = new StereOffWithCDCommand(stereo);

            //addCommand
            remoteControl.setCommand(0,lightOnCommand,lightOffCommand);
            remoteControl.setCommand(1,ceilingFanHignOnCommand,ceilingFanHighOffCommand);
            remoteControl.setCommand(2, garaDoorOnCommand, garaDoorOffCommand);
            remoteControl.setCommand(3,stereOnWithCDCommand,stereOffWithCDCommand);

            //test
            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
            remoteControl.onButtonWasPushed(3);
            remoteControl.offButtonWasPushed(3);

            //CeilFanHigh
            CeilingFanHighMediumCommand fanMediumCommand = new CeilingFanHighMediumCommand(ceilingFanHigh);
            CeilingFanHighLowCommand fanLowCommand = new CeilingFanHighLowCommand(ceilingFanHigh);
            remoteControl.setCommand(4,fanMediumCommand,fanLowCommand);
            remoteControl.onButtonWasPushed(1);//高档
            remoteControl.onButtonWasPushed(4);//中档
            remoteControl.offButtonWasPushed(4);//低档
            remoteControl.offButtonWasPushed(1);//关闭

            Console.WriteLine("");
            MacroCommand macrocommand = new MacroCommand();
            macrocommand.addCommand(fanMediumCommand);
            macrocommand.addCommand(fanLowCommand);
            macrocommand.addCommand(lightOnCommand);
            remoteControl.setCommand(5,macrocommand,new NoCommand());
            remoteControl.onButtonWasPushed(5);
            Console.WriteLine("");
            remoteControl.undoButtonWasPushed();
            Console.ReadLine();
        }
    }
}
