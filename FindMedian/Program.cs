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
            // insertion sort
            for (int i = 0; i < arr.Count; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            return arr[arr.Count / 2];
        }
    }
}
