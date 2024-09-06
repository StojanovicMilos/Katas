public abstract class StraightMovement
{
    public abstract Direction Direction { get; }
    public State Move(CommandData commandData)
    {
        var state = commandData.State;
        var obstacles = commandData.Obstacles;
        var numberOfMovements = commandData.CommandId;
        while (numberOfMovements > 0)
        {
            var nextPosition = GetNextPosition(state.Position);
            if (obstacles.HasObstacleAt(nextPosition))
            {
                break;
            }
            else
            {
                state.Position = nextPosition;
                numberOfMovements--;
            }
        }

        return state;
    }

    protected abstract Position GetNextPosition(Position currentPosition);
}
