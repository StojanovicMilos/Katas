internal class PointsMatrix(int[][] points)
{
    public int CalculatePoints(CellPosition[] cellPositions)
    {
        var result = 0;

        int? previousColumn = null;
        foreach (var cellPosition in cellPositions)
        {
            result += points[cellPosition.Row][cellPosition.Column];
            if (previousColumn != null)
            {
                result -= Math.Abs(previousColumn.Value - cellPosition.Column);
            }

            previousColumn = cellPosition.Column;
        }

        return result;
    }

    private static CellPosition GetCurrent(CellPosition[] cellPositions, int i) => cellPositions[i];
}
