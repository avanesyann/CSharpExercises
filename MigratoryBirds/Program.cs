namespace MigratoryBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MigratoryBirds(new List<int> { 1, 4, 4, 4, 5, 3 }));
            Console.WriteLine(MigratoryBirds(new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }));
        }

        static int MigratoryBirds(List<int> birds)
        {
            Dictionary<int, int> birdCounts = new Dictionary<int, int>();

            foreach (int bird in birds)
            {
                if (!birdCounts.ContainsKey(bird))
                    birdCounts[bird] = 0;

                birdCounts[bird]++;
            }

            return birdCounts.OrderByDescending(x => x.Value).ThenBy(y => y.Key).First().Key;
        }
    }
}
