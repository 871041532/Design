using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Command
{
    //命令接口，持有执行命令的receiver对象，当excute()被调用时执行内部对象的特定方法。
    public interface Command
    {
        void execute();//命令执行
        void undo();//撤销执行
    }
    //空开关
    public class NoCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("空命令执行");
        }

        public void undo()
        {
            Console.WriteLine("空命令撤销");
        }
    }
    //音响开
    public class StereOnWithCDCommand : Command
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
    //音响关
    public class StereOffWithCDCommand : Command
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
    //灯开
    public class LightOnCommand : Command
    {
        Light light;
        public LightOnCommand(Light _light)
        {
            light = _light;
        }
        public void execute()
        {
            light.on();
        }

        public void undo()
        {
            light.off();
        }
    }
    //灯关
    public class LightOffCommand : Command
    {
        Light light;
        public LightOffCommand(Light _light)
        {
            light = _light;
        }
        public void execute()
        {
            light.off();
        }

        public void undo()
        {
            light.on();
        }
    }
    //天花板吊扇开
    public class CeilingFanHighOnCommand : Command
    {
        CeilingFanHigh receiver;
        int preSpeed;

        public CeilingFanHighOnCommand(CeilingFanHigh _receiver)
        {
            receiver = _receiver;
        }
        public void execute()
        {
            preSpeed = receiver.getSpeed();
            receiver.high();
        }
        public void undo()
        {
            if (preSpeed==CeilingFanHigh.HIGH)
            {
                receiver.high();
            }
            else if(preSpeed == CeilingFanHigh.MEDIUM)
            {
                receiver.medium();
            }
            else if (preSpeed == CeilingFanHigh.LOW)
            {
                receiver.low();
            }
            else if (preSpeed == CeilingFanHigh.OFF)
            {
                receiver.off();
            }
        }
    }

    //天花板吊扇中速
    public class CeilingFanHighMediumCommand : Command
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
            }
            else if (preSpeed == CeilingFanHigh.MEDIUM)
            {
                receiver.medium();
            }
            else if (preSpeed == CeilingFanHigh.LOW)
            {
                receiver.low();
            }
            else if (preSpeed == CeilingFanHigh.OFF)
            {
                receiver.off();
            }
        }
    }

    //天花板吊扇低速
    public class CeilingFanHighLowCommand : Command
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
            }
            else if (preSpeed == CeilingFanHigh.MEDIUM)
            {
                receiver.medium();
            }
            else if (preSpeed == CeilingFanHigh.LOW)
            {
                receiver.low();
            }
            else if (preSpeed == CeilingFanHigh.OFF)
            {
                receiver.off();
            }
        }
    }

    //天花板吊扇关
    public class CeilingFanHighOffCommand : Command
    {
        CeilingFanHigh receiver;
        int preSpeed;
        public CeilingFanHighOffCommand(CeilingFanHigh _receiver)
        {
            receiver = _receiver;
        }
        public void execute()
        {
            preSpeed = receiver.getSpeed();
            receiver.off();
        }
        public void undo()
        {
            if (preSpeed == CeilingFanHigh.HIGH)
            {
                receiver.high();
            }
            else if (preSpeed == CeilingFanHigh.MEDIUM)
            {
                receiver.medium();
            }
            else if (preSpeed == CeilingFanHigh.LOW)
            {
                receiver.low();
            }
            else if (preSpeed == CeilingFanHigh.OFF)
            {
                receiver.off();
            }
        }
    }

    //车库门开
    public class GarageDoorOnCommand : Command
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

    //车库门关
    public class GarageDoorOffCommand : Command
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

    //宏命令
    public class MacroCommand : Command
    {
        List<Command> commands=new List<Command>();
        public MacroCommand(IEnumerable<Command> _commands=null)
        {
            if (_commands!=null)
            {
                commands.AddRange(_commands);
            }
        }
        public void addCommand(Command _command)
        {
            commands.Add(_command);
        }
        public void execute()
        {
            foreach (Command item in commands)
            {
                item.execute();
            }
        }
        public void undo()
        {
            foreach (Command item in commands)
            {
                item.undo();
            }
        }
    }
}
