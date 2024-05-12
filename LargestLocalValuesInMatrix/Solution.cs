using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestLocalValuesInMatrix;
//https://leetcode.com/problems/largest-local-values-in-a-matrix/?envType=daily-question&envId=2024-05-12
internal static class Solution
{
    public static int[][] LargestLocal(int[][] grid)
    {
        int[][] solution = new int[grid.Length - 2][];

        for (int i = 0; i < grid.Length - 2; i++)
        {
            solution[i] = new int[grid[i].Length - 2];
        }

        for (int i = 1; i < grid.Length - 1; i++)
        {
            for (int j = 1; j < grid[i].Length - 1; j++)
            {
                solution[i - 1][j - 1] = GetMax(grid, i, j);
            }
        }

        return solution;
    }

    private static int GetMax(int[][] grid, int i, int j)
    {
        int[] items = [
            GetTopLeft(grid, i, j), GetTop(grid, i, j), GetTopRight(grid, i, j),
            GetLeft(grid, i, j), GetCenter(grid, i, j), GetRight(grid, i, j),
            GetBottomLeft(grid, i, j), GetBottom(grid, i, j), GetBottomRight(grid, i, j)
            ];

        return items.Max();
    }

    private static int GetTopLeft(int[][] grid, int i, int j)
    {
        return grid[i - 1][j - 1];
    }

    private static int GetTop(int[][] grid, int i, int j)
    {
        return grid[i - 1][j];
    }

    private static int GetTopRight(int[][] grid, int i, int j)
    {
        return grid[i - 1][j + 1];
    }

    private static int GetLeft(int[][] grid, int i, int j)
    {
        return grid[i][j - 1];
    }

    private static int GetCenter(int[][] grid, int i, int j)
    {
        return grid[i][j];
    }

    private static int GetRight(int[][] grid, int i, int j)
    {
        return grid[i][j + 1];
    }

    private static int GetBottomLeft(int[][] grid, int i, int j)
    {
        return grid[i + 1][j - 1];
    }

    private static int GetBottom(int[][] grid, int i, int j)
    {
        return grid[i + 1][j];
    }

    private static int GetBottomRight(int[][] grid, int i, int j)
    {
        return grid[i + 1][j + 1];
    }
}