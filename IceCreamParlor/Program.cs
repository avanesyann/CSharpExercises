namespace IceCreamParlor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int>() { 1, 3, 4, 5, 6 };
            IceCreamParlor(6, prices);
        }

        static List<int> IceCreamParlor(int m, List<int> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] + arr[j] == m)
                        return new List<int>() { j+1, i+1 };
                }
            }

            return new List<int>();
        }
    }
}
