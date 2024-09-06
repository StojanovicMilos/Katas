public class State
{
    public Position Position { get; set; } = new(0, 0);
    public Direction Direction { get; set; } = Direction.North;
    public int MaximumDistance { get; set; } = 0;

    public void UpdateMaximumDistance()
    {
        var currentDistance = Position.CalculateDistanceToStart();
        if (currentDistance > MaximumDistance)
        {
            MaximumDistance = currentDistance;
        }
    }
}
