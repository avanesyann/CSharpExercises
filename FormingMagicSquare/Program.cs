﻿namespace FormingMagicSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> square = new List<List<int>>()
            {
                new List<int>() { 5, 3, 4 },
                new List<int>() { 1, 5, 8 },
                new List<int>() { 6, 4, 2 }
            };
            MagicSquare(square);
        }

        static int MagicSquare(List<List<int>> s)
        {
            List<int[,]> magicSquares = new List<int[,]>()
            {
                new int[,] { {8, 1, 6}, {3, 5, 7}, {4, 9, 2} },
                new int[,] { {6, 1, 8}, {7, 5, 3}, {2, 9, 4} },
                new int[,] { {4, 9, 2}, {3, 5, 7}, {8, 1, 6} },
                new int[,] { {2, 9, 4}, {7, 5, 3}, {6, 1, 8} },
                new int[,] { {8, 3, 4}, {1, 5, 9}, {6, 7, 2} },
                new int[,] { {4, 3, 8}, {9, 5, 1}, {2, 7, 6} },
                new int[,] { {6, 7, 2}, {1, 5, 9}, {8, 3, 4} },
                new int[,] { {2, 7, 6}, {9, 5, 1}, {4, 3, 8} }
            };

            int minCost = int.MaxValue;

            foreach (var square in magicSquares)
            {
                int cost = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cost += Math.Abs(s[i][j] - square[i, j]);
                    }
                }

                minCost = Math.Min(minCost, cost);
            }

            return minCost;
        }
    }
}
