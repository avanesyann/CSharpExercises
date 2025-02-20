namespace DivisibleSumPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            int k = 5;

            Console.WriteLine(DivisibleSumPairs(k, numbers));
        }


        static int DivisibleSumPairs(int k, List<int> numbers)
        {
            int countPairs = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if ((numbers[i] + numbers[j]) % k == 0)
                    {
                        countPairs++;
                        Console.WriteLine($"[{numbers[i]}; {numbers[j]}]");
                    }

                    //Console.WriteLine($"[{i}; {j}]");
                }
            }
            return countPairs;
        }
    }
}
