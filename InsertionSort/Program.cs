namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 4, 6, 8, 3 };
            InsertionSort(list.Count, list);
        }

        public static void InsertionSort(int n, List<int> arr)
        {
            int last = arr[n - 1];
            int i;

            for (i = n - 2; i >= 0 && arr[i] > last; i--)
            {
                arr[i + 1] = arr[i];

                Console.WriteLine(string.Join(" ", arr));
            }

            arr[i + 1] = last;
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
