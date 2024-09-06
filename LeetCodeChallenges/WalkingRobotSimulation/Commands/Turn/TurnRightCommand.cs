public class TurnRightCommand : TurnCommand
{
    public override bool ShouldExecute(int commandId) => commandId == -1;

    protected override Direction ChangeDirection(Direction direction)
        => direction switch
        {
            Direction.North => Direction.East,
            Direction.East => Direction.South,
            Direction.South => Direction.West,
            Direction.West => Direction.North,
            _ => throw new InvalidOperationException()
        };
}