public class EastMovement : StraightMovement
{
    public override Direction Direction => Direction.East;

    protected override Position GetNextPosition(Position currentPosition) => new(currentPosition.X + 1, currentPosition.Y);
}
