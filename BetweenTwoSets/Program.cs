namespace BetweenTwoSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testing

            List<int> a = new List<int>() { 2, 4 };
            List<int> b = new List<int>() { 16, 32, 96 };

            Console.WriteLine(Solution.GetTotalX(a, b));

        }
    }
}
