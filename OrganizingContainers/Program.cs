namespace OrganizingContainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>();
            list.Add(new List<int>() { 1, 4 });
            list.Add(new List<int>() { 2, 3 });

            Console.WriteLine(OrganizingContainers(list));
        }

        static string OrganizingContainers(List<List<int>> container)
        {
            List<int> ballCount = new List<int>(new int[container.Count]);
            List<int> ballTypeCount = new List<int>(new int[container.Count]);

            for (int i = 0; i < container.Count; i++)
            {
                for (int j = 0; j < container.Count; j++)
                {
                    ballCount[i] += container[i][j];
                    ballTypeCount[j] += container[i][j];
                }
            }

            ballCount.Sort();
            ballTypeCount.Sort();

            return ballCount.SequenceEqual(ballTypeCount) ? "Possible" : "Impossible";
        }
    }
}
