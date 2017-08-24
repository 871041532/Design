package Command.implCommand;
import Command.interfaces.Command;
import java.util.ArrayList;
import java.util.Collection;

//宏命令
public class MacroCommand implements Command
{
    ArrayList<Command> commands = new ArrayList<Command>();

    public MacroCommand(Collection<? extends Command> _commands)
    {
        if (_commands != null)
        {
            commands.addAll(_commands);
        }
    }

    public void addCommand(Command _command)
    {
        commands.add(_command);
    }

    public void execute()
    {
        for (Command item : commands)
        {
            item.execute();
        }
    }

    public void undo()
    {
        for (Command item : commands)
        {
            item.undo();
        }
    }
}