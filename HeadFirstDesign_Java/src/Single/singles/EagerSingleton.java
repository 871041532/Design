package Single.singles;

//急切实例化
public class EagerSingleton
{
    private static EagerSingleton instance = new EagerSingleton();

    private EagerSingleton()
    {
        System.out.println("新的EagerSingleton对象被创建");
    }

    public static EagerSingleton getInstance()
    {
        return instance;
    }
}
