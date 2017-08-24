package Single.singles;

//双重检查锁实现单例，适用于1.5以及以上版本
public class DoubleLockSingleton
{
    //volatile关键字用于保持原子性。 多个线程同时访问一个变量，JVM为了效率，允许每个线程进行本地缓存，这就导致了变量的不一致性。volatile就是为了解决这个问题，volatile修饰的变量，不允许线程进行本地缓存，每个线程的读写都是直接操作在共享内存上，这就保证了变量始终具有一致性。
    private volatile static DoubleLockSingleton instance;
    private DoubleLockSingleton()
    {
        System.out.println("新的DoubleLockSingleton被创建");
    }

    public static DoubleLockSingleton getInstance()
    {
        if (instance==null)
        {
            synchronized (DoubleLockSingleton.class){
                if (instance==null)
                {
                    instance=new DoubleLockSingleton();
                }
            }
        }
        return instance;
    }
}
