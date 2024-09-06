public class WestMovement : StraightMovement
{
    public override Direction Direction => Direction.West;

    protected override Position GetNextPosition(Position currentPosition) => new(currentPosition.X - 1, currentPosition.Y);
}
