package Command.interfaces;

//调用者持有command命令对象并在某个时间点调用excute()方法
public abstract class Invoker
{
    public abstract void setCommand(int slot, Command onCommand, Command offCommand);
}
