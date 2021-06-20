using System;
using System.Collections.Generic;

namespace MaxAreaOfIsland
{
    //https://leetcode.com/problems/max-area-of-island/
    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            bool[,] visited = new bool[grid.Length, grid[0].Length];
            int maxSize = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        continue;
                    }

                    if (visited[i, j])
                    {
                        continue;
                    }

                    visited[i, j] = true;
                    var size = GetIslandSize(grid, visited, i, j);
                    if (size > maxSize)
                    {
                        maxSize = size;
                    }
                }
            }

            return maxSize;
        }

        private int GetIslandSize(int[][] grid, bool[,] visited, int i, int j)
        {
            int islandSize = 1; //current i,j element
            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            stack.Push(new Tuple<int, int>(i, j));

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                foreach (var neighbour in GetNeighbours(grid, current.Item1, current.Item2))
                {
                    if (visited[neighbour.Item1, neighbour.Item2])
                    {
                        continue;
                    }

                    visited[neighbour.Item1, neighbour.Item2] = true;
                    stack.Push(neighbour);
                    islandSize++;
                }
            }

            return islandSize;
        }

        private IEnumerable<Tuple<int, int>> GetNeighbours(int[][] grid, int i, int j)
        {
            var result = new List<Tuple<int, int>>();
            if (HasLeft(grid, i, j))
            {
                result.Add(GetLeft(i, j));
            }

            if (HasRight(grid, i, j))
            {
                result.Add(GetRight(i, j));
            }

            if (HasUp(grid, i, j))
            {
                result.Add(GetUp(i, j));
            }

            if (HasDown(grid, i, j))
            {
                result.Add(GetDown(i, j));
            }

            return result;
        }

        private static bool HasLeft(int[][] grid, int i, int j)
        {
            try
            {
                var value = grid[i - 1][j];
                return value == 1;
            }
            catch
            {
                return false;
            }
        }

        private static Tuple<int, int> GetLeft(int i, int j) => new Tuple<int, int>(i - 1, j);

        private static bool HasRight(int[][] grid, int i, int j)
        {
            try
            {
                var value = grid[i + 1][j];
                return value == 1;
            }
            catch
            {
                return false;
            }
        }

        private static Tuple<int, int> GetRight(int i, int j) => new Tuple<int, int>(i + 1, j);

        private static bool HasUp(int[][] grid, int i, int j)
        {
            try
            {
                var value = grid[i][j + 1];
                return value == 1;
            }
            catch
            {
                return false;
            }
        }

        private static Tuple<int, int> GetUp(int i, int j) => new Tuple<int, int>(i, j + 1);

        private static bool HasDown(int[][] grid, int i, int j)
        {
            try
            {
                var value = grid[i][j - 1];
                return value == 1;
            }
            catch
            {
                return false;
            }
        }

        private static Tuple<int, int> GetDown(int i, int j) => new Tuple<int, int>(i, j - 1);

    }
}
