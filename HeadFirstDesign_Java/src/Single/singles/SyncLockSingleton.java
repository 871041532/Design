package Single.singles;

//同步锁实例化
public class SyncLockSingleton
{
    private static SyncLockSingleton instance = null;

    private SyncLockSingleton()
    {
        System.out.println("新的SyncLockSingleton对象被创建");
    }

    public synchronized static SyncLockSingleton getInstance()
    {
        if (instance == null)
        {
            instance = new SyncLockSingleton();
        }
        return instance;
    }
}
