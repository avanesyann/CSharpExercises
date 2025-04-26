namespace Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> testList1 = new List<int>() { 1, 2, 3, 4 };
            List<int> testList2 = new List<int>() { 5, 2, 6, 8, 3, 10, 4 };

            Console.WriteLine(Pairs(1, testList1));
            Console.WriteLine(Pairs(6, testList2));
        }

        static int Pairs(int k, List<int> arr)
        {
            int amount = 0;
            
            for (int i = 0; i < arr.Count - 1; i++)
            {
                for (int j = 1; j < arr.Count; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == k)
                        amount++;
                }
            }

            return amount;
        }
    }
}
