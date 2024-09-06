public class SouthMovement : StraightMovement
{
    public override Direction Direction => Direction.South;

    protected override Position GetNextPosition(Position currentPosition) => new(currentPosition.X, currentPosition.Y - 1);
}
