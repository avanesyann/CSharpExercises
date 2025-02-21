namespace HurdleRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HurdleRace(5, new List<int> { 4, 6, 5, 3, 7, 1, 2}));
        }

        static int HurdleRace(int k, List<int> height)
        {
            int maxHurdle = height.Max();

            if (k >= maxHurdle)
                return 0;

            return maxHurdle - k;
        }
    }
}
