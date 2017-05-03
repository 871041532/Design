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
            Console.WriteLine("灯开了。");
        }

        public override void on()
        {
            Console.WriteLine("灯关了。");
        }
    }
    //音响
    public class Stereo : Receiver
    {
        public override void off()
        {
            Console.WriteLine("音响开了。");
        }

        public override void on()
        {
            Console.WriteLine("音响关了");
        }
    }
}
