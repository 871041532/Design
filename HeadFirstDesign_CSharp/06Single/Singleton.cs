using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace _06Single
{
   //同步锁实例化
   public class SyncLockSingleton
    {
        private static SyncLockSingleton instance = null;
        private static object locker = new object();
        private SyncLockSingleton() { Console.WriteLine("新的SyncLockSingleton对象被创建"); }
        public static SyncLockSingleton getInstance()
        {
            lock (locker)
            {
                if (instance==null)
                {
                    instance = new SyncLockSingleton();
                }
                return instance;
            }
        }
    }

    //急切实例化
    public class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();
        private EagerSingleton() {
            Console.WriteLine("新的EagerSingleton对象被创建");
        }
        public static EagerSingleton getInstance() {
            return instance;
        }
    }

    //双重检查加锁
    public class Singleton
    {
        private static volatile Singleton instance =null;//多个线程同时访问一个变量，CLR为了效率，允许每个线程进行本地缓存，这就导致了变量的不一致性。volatile就是为了解决这个问题，volatile修饰的变量，不允许线程进行本地缓存，每个线程的读写都是直接操作在共享内存上，这就保证了变量始终具有一致性。
        private static object locker = new object();
        private Singleton()
        {
            Console.WriteLine("新的Singleton对象被创建");
        }
         public  static Singleton getInstance()
        {
            if (instance==null)//检查实例，如果不存在就进入同步区块
            {
                lock (locker)
                {
                    if (instance == null)//进入同步区块后再检查一次，如果仍然是null才创建实例
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

}
