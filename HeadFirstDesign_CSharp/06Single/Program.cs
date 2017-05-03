using System;
using System.Threading;

namespace _06Single
{
    class Program
    {
        static void Main(string[] args)
        {
            /*单例模式
             * 确保一个类只有一个实例，并提供一个全局访问点。
             * 单线程简单实现方式：私有构造器，静态变量，静态方法。
             * 简单单例无法应对多线程环境，故而有同步锁实例化，急切实例化，双重检查锁实例化三种完善方式。
             */

            Thread t1 = new Thread(new ThreadStart(childThread));
            Thread t2 = new Thread(new ThreadStart(childThread));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }

        static void childThread()
        {
            Singleton single = Singleton.getInstance();
            EagerSingleton single02 = EagerSingleton.getInstance();
            SyncLockSingleton single03 = SyncLockSingleton.getInstance();
        }
    }
}
