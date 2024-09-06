public class NorthMovement : StraightMovement
{
    public override Direction Direction => Direction.North;

    protected override Position GetNextPosition(Position currentPosition) => new(currentPosition.X, currentPosition.Y + 1);
}
