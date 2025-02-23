namespace BreakingTheRecords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> season1 = BreakingRecords(new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 });
            List<int> season2 = BreakingRecords(new List<int> { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 });

            foreach (int score in season1)
            {
                Console.Write(score + " ");
            }
            foreach (int score in season2)
            {
                Console.Write(score + " ");
            }
        }

        /// <summary>
        /// Determines the number of times the highest and lowest records are broken.
        /// </summary>
        /// <param name="scores">List of game scores</param>
        /// <returns>List<int>: [times high record broken, times low record broken]</int></returns>
        static List<int> BreakingRecords(List<int> scores)
        {
            if (scores == null || scores.Count == 0)
                throw new ArgumentException("Score list cannot be null or empty.");

            int lowest = scores[0];
            int highest = scores[0];

            int lowCount = 0;
            int highCount = 0;

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                    highCount++;
                }
                else if (scores[i] < lowest)
                {
                    lowest = scores[i];
                    lowCount++;
                }
            }

            return new List<int> { highCount, lowCount };
        }
    }
}
