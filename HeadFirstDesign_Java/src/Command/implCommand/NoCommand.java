package Command.implCommand;
import Command.interfaces.Command;

//空开关
public class NoCommand implements Command
{
    @Override
    public void execute()
    {
        System.out.println("空命令执行");
    }

    @Override
    public void undo()
    {
        System.out.println("空命令撤销");
    }
}
