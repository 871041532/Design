package Single;

import Single.singles.DoubleLockSingleton;
import Single.singles.EagerSingleton;
import Single.singles.SyncLockSingleton;

/*单例模式
 * 确保一个类只有一个实例，并提供一个全局访问点。
 * 单线程简单实现方式：私有构造器，静态变量，静态方法。
 * 简单单例无法应对多线程环境，故而有同步锁实例化，急切实例化，双重检查锁实例化三种完善方式。
 */
public class Single
{
    public static void main(String[] args)
    {
        Thread t1=new Thread(()->{
            childThread();
        });
        Thread t2=new Thread(()->{
            childThread();
        });
        t1.start();
        t2.start();
    }
    static void childThread()
    {
        SyncLockSingleton single = SyncLockSingleton.getInstance();
        EagerSingleton single02 = EagerSingleton.getInstance();
        DoubleLockSingleton single03 = DoubleLockSingleton.getInstance();
    }
}
