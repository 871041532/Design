using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07Command
{
   public abstract class Receiver
   {
        public abstract void on();
        public abstract void off();
   }
    //灯
    public class Light : Receiver
    {
        public override void off()
        {
            Console.WriteLine("灯关了。");
        }

        public override void on()
        {
            Console.WriteLine("灯开了。");
        }
    }
    //音响
    public class Stereo : Receiver
    {
        public override void off()
        {
            Console.WriteLine("音响关了。");
        }

        public override void on()
        {
            Console.WriteLine("音响开了");
        }
        public void setCD()
        {
            Console.WriteLine("插入CD");
        }
        public void setVolume(int volume)
        {
            Console.WriteLine("设置音响音量 "+volume);
        }
    }
    //天花板吊扇
    public class CeilingFanHigh : Receiver
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        string location;
        int speed;
        public CeilingFanHigh(string _location="天花板")
        {
            location = _location;
            speed = OFF;
        }
        public void high()
        {
            speed = HIGH;
            Console.WriteLine("天花板吊扇变为高速了");
        }
        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine("天花板吊扇变为中等转速");
        }
        public void low()
        {
            speed = LOW;
            Console.WriteLine("天花板吊扇变为低转速");
        }


        public override void off()
        {
            speed = OFF;
            Console.WriteLine("天花板吊扇关了");
        }
        public override void on()
        {
            high();          
        }
        public int getSpeed()
        {
            return speed;
        }
    }
    //车库门
    public class GarageDoor : Receiver
    {
        public override void off()
        {
            Console.WriteLine("车库门关了");
        }

        public override void on()
        {
            Console.WriteLine("车库门开了");
        }
    }
}
