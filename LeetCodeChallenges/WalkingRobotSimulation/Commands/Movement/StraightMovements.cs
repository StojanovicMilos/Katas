public class StraightMovements : Command
{
    private readonly StraightMovement[] _straightMovements = [new NorthMovement(), new EastMovement(), new SouthMovement(), new WestMovement()];

    public override bool ShouldExecute(int commandId) => commandId >= 1 && commandId <= 9;

    public override State Execute(CommandData commandData)
    {
        var newState = _straightMovements
            .Single(m => m.Direction == commandData.State.Direction)
            .Move(commandData);
        newState.UpdateMaximumDistance();
        return newState;
    }
}
