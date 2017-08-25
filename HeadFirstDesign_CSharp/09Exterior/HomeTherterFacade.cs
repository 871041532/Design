using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Exterior
{
    public class HomeTherterFacade
    {
        Amplifier amp;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;
        Projector projector;
        TheaterLights lights;
        Screen screen;
        PopcornPopper popper;
        public HomeTherterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper)
        {
            this.amp = amp;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.lights = lights;
            this.screen = screen;
            this.popper = popper;
        }

        public void watchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch amovie...");
            popper.on();
            popper.pop();
            lights.dim(10);
            screen.down();
            projector.on();
            projector.wideScreenMode();
            amp.on();
            amp.setSurroundSound();
            amp.setVolume(5);
            dvd.on();
            dvd.play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("结束播放电影...");
            popper.off();
            lights.on();
            screen.up();
            projector.off();
            amp.off();
            dvd.stop();
            dvd.eject();
            dvd.off();
        }
    }




    //扩音器
    public class Amplifier
    {
        internal void off()
        {
            Console.WriteLine("音响关闭..");
        }

        internal void on()
        {
            Console.WriteLine("音响打开..");
        }

        internal void setSurroundSound()
        {
            Console.WriteLine("设置环绕音..");
        }

        internal void setVolume(int v)
        {
            Console.WriteLine("设置音量"+v+"..");
        }
    }
    //调音器
    public class Tuner
    {

    }
    //DVD播放器
    public class DvdPlayer
    {
        internal void eject()
        {
            Console.WriteLine("DVD推出光盘..");
        }

        internal void off()
        {
            Console.WriteLine("DVD关闭..");
        }

        internal void on()
        {
            Console.WriteLine("DVD打开..");
        }

        internal void play(string movie)
        {
            Console.WriteLine("DVD开始播放"+ movie+"..");
        }

        internal void stop()
        {
            Console.WriteLine("DVD停止..");
        }
    }
    //CD播放器
    public class CdPlayer
    {

    }
    //投影仪
    public class Projector
    {
        internal void off()
        {
            Console.WriteLine("投影仪关闭..");
        }

        internal void on()
        {
            Console.WriteLine("投影仪打开..");
        }

        internal void wideScreenMode()
        {
            Console.WriteLine("投影仪宽屏显示..");
        }
    }
    //剧场灯
    public class TheaterLights
    {
        internal void dim(int v)
        {
            Console.WriteLine("剧场灯亮度调到10..");
        }

        internal void on()
        {
            Console.WriteLine("剧场灯关闭..");
        }
    }
    //显示屏
    public class Screen
    {
        internal void down()
        {
            Console.WriteLine("屏幕放下..");
        }

        internal void up()
        {
            Console.WriteLine("屏幕拉起..");
        }
    }
    //爆米花
    public class PopcornPopper
    {
        internal void pop()
        {
            Console.WriteLine("出爆米花..");
        }

        internal void on()
        {
            Console.WriteLine("爆米花机器打开..");
        }

        internal void off()
        {
            Console.WriteLine("爆米花机器关闭..");
        }
    }
}
