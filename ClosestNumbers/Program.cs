namespace ClosestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 2, 3, 4, 1 };
            Console.WriteLine(string.Join("", ClosestNumbers(numbers)));
        }

        static List<int> ClosestNumbers(List<int> arr)
        {
            arr.Sort();

            int minDiff = int.MaxValue;
            List<int> result = new List<int>();

            for (int i = 1; i < arr.Count; i++)
            {
                int diff = arr[i] - arr[i - 1];

                if (diff < minDiff)
                {
                    minDiff = diff;
                    result.Clear();
                    result.Add(arr[i - 1]);
                    result.Add(arr[i]);
                }
                else if (diff == minDiff)
                {
                    result.Add(arr[i - 1]);
                    result.Add(arr[i]);
                }
            }

            return result;
        }
    }
}
