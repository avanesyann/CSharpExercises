namespace ServiceLane
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static List<int> ServiceLane(List<int> width, List<List<int>> cases)
        {
            List<int> results = new List<int>();

            foreach (var testCase in cases)
            {
                int entry = testCase[0];
                int exit = testCase[1];

                int minWidth = width.GetRange(entry, exit - entry + 1).Min();

                results.Add(minWidth);
            }

            return results;
        }
    }
}
