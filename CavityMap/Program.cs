namespace CavityMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cavityMap = CavityMap(["1112", "1912", "1892", "1234"]);

            foreach (string row in cavityMap)
            {
                Console.WriteLine(row);
            }
        }

        static List<string> CavityMap(List<string> grid)
        {
            char[][] newGrid = grid.Select(row => row.ToCharArray()).ToArray();

            for (int i = 1; i < grid.Count - 1; i++)
            {
                for (int j = 1; j < grid[i].Length - 1; j++)
                {
                    char current = grid[i][j];

                    if (current > grid[i - 1][j] && current > grid[i + 1][j] && 
                        current > grid[i][j - 1] && current > grid[i][j + 1])
                    {
                        newGrid[i][j] = 'X';
                    }
                }
            }

            return newGrid.Select(row => new string(row)).ToList();
        }
    }
}
