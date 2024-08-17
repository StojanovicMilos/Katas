// https://leetcode.com/problems/maximum-number-of-points-with-cost/description/?envType=daily-question&envId=2024-08-17

Console.WriteLine("Hello, World!");

int[][] points = [
    [1, 2, 3],
    [1, 5, 1],
    [3, 1, 1]
    ];

var pointsMatrix = new PointsMatrix(points);

Console.WriteLine(pointsMatrix.CalculatePoints([new CellPosition(0, 2), new CellPosition(1, 1), new CellPosition(2, 0)]));