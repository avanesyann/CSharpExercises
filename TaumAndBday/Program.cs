namespace TaumAndBday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TaumBday(3, 5, 3, 4, 1));
        }

        static long TaumBday(int b, int w, int bc, int wc, int z)
        {
            long minBlack = Math.Min(bc, wc + z);
            long minWhite = Math.Min(wc, bc + z);

            return (b * minBlack) + (w * minWhite);
        }
    }
}
