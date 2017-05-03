using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Command
{
    //命令接口
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
