public class Obstacles
{
    private readonly HashSet<(int, int)> _obstacles = new();

    public Obstacles(int[][] obstacles)
    {
        ArgumentNullException.ThrowIfNull(obstacles);
        foreach (var obstacle in obstacles.Where(o => o.Length == 2).Select(o => (o[0], o[1])))
        {
            _obstacles.Add(obstacle);
        }
    }

    public bool HasObstacleAt(Position position) => _obstacles.Contains((position.X, position.Y));
}
