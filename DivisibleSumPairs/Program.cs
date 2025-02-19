namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            int k = 5;

            DivisibleSumPairs(numbers, k);
        }


        static int DivisibleSumPairs(List<int> numbers, int k)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                for (int j = numbers.Count - 1; j < numbers.Count; j++)
                {
                    Console.WriteLine($"[{i}; {j}]");
                }
            }
            return 0;
        }
    }
}
