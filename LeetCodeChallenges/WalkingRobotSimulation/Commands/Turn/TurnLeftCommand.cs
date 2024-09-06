public class TurnLeftCommand : TurnCommand
{
    public override bool ShouldExecute(int commandId) => commandId == -2;

    protected override Direction ChangeDirection(Direction direction)
       => direction switch
       {
           Direction.North => Direction.West,
           Direction.West => Direction.South,
           Direction.South => Direction.East,
           Direction.East => Direction.North,
           _ => throw new InvalidOperationException()
       };
}
