namespace FlatlandStations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FlatlandSpaceStations(3, [1]));
        }

        static int FlatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int maxDistance = 0;

            maxDistance = Math.Max(maxDistance, c[0]);

            for (int i = 1; i < c.Length; i++)
            {
                int distance = (c[i] - c[i - 1]) / 2;
                maxDistance = Math.Max(maxDistance, distance);
            }

            maxDistance = Math.Max(maxDistance, (n - 1) - c[^1]);

            return maxDistance;
        }
    }
}
