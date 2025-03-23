namespace BeautifulTriplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BeautifulTriplets(1, [2, 2, 3, 4, 5]));
        }

        static int BeautifulTriplets(int d, List<int> arr)
        {
            int count = 0;
            HashSet<int> numbers = new HashSet<int>(arr);

            foreach (int num in arr)
            {
                if (numbers.Contains(num + d) && numbers.Contains(num + 2 * d))
                    count++;
            }

            return count;
        }
    }
}
