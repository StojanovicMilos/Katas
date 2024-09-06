public abstract class Command
{
    public abstract bool ShouldExecute(int commandId);
    public abstract State Execute(CommandData commandData);
}
