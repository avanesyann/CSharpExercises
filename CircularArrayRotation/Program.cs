namespace CircularArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> test1 = CircularArrayRotation(new List<int>() { 3, 4, 5 }, 2, new List<int>() { 1, 2 });
            List<int> test2 = CircularArrayRotation(new List<int>() { 15, 23, 12, 82, 62, 42, 16, 19, 91, 81, 6, 32, 4 }, 4, new List<int>() { 1, 2, 3, 4 });

            Console.WriteLine(string.Join(" ", test1));
            Console.WriteLine(string.Join(" ", test2));
        }

        static List<int> CircularArrayRotation(List<int> a, int k, List<int> queries)
        {
            int n = a.Count;
            k = k % n;
            List<int> shifted = new List<int>(new int[n]);
            
            for (int i = 0; i < n; i++)
            {
                int newIndex = (i + k) % n;
                shifted[newIndex] = a[i];
            }

            List<int> result = new List<int>();
            foreach (int query in queries)
            {
                result.Add(shifted[query]);
            }

            return result;
        }
    }
}
