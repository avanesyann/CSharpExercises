namespace MinimumDistances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinimumDistances(new List<int> { 3, 2, 1, 2, 3 }));
        }
        static int MinimumDistances(List<int> numbers)
        {
            List<int> distances = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                        distances.Add(Math.Abs(i - j));

                }
            }
            return distances.Count > 0 ? distances.Min() : -1;
        }
    }
}
