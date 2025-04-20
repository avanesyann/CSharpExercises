namespace GridChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> grid = new List<string>() { "ebacd", "fghij", "olmkn", "trpqs", "xywuv" };
            Console.WriteLine(GridChallenge(grid));
        }

        static string GridChallenge(List<string> grid)
        {
            for (int i = 0; i < grid.Count; i++)
            {
                char[] rowChars = grid[i].ToCharArray();
                Array.Sort(rowChars);
                grid[i] = new string(rowChars);
            }

            for (int i = 1; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] < grid[i - 1][j])
                        return "NO";
                }
            }

            return "YES";
        }
    }
}
