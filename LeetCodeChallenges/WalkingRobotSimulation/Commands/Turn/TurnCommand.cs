public abstract class TurnCommand : Command
{
    public override State Execute(CommandData commandData)
    {
        var state = commandData.State;
        state.Direction = ChangeDirection(state.Direction);
        return state;
    }

    protected abstract Direction ChangeDirection(Direction direction);
}
