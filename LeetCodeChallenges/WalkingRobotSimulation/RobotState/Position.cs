public record class Position(int X, int Y)
{
    public int CalculateDistanceToStart() => X * X + Y * Y;
}
