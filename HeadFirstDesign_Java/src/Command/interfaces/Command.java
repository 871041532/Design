package Command.interfaces;

//命令接口，持有执行命令的receiver对象，当excute()被调用时执行内部对象的特定方法。
public interface Command
{
    void execute();//命令执行
    void undo();//撤销执行
}
