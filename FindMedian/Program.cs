namespace FindMedian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 14, 8, 21, 9, 10, 4, 16 };
            Console.WriteLine(FindMedian(numbers));
        }

        static int FindMedian(List<int> arr)
        {
            arr.Sort();

            return arr[arr.Count / 2];
        }
    }
}
