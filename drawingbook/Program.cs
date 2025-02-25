namespace DrawingBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PageCount(5, 4));
            Console.WriteLine(PageCount(5, 1));
            Console.WriteLine(PageCount(5, 3));
        }

        static int PageCount(int n, int p)
        {
            if (n < p || p < 1)
                throw new ArgumentException("Invalid page number.");

            int frontTurns = p / 2;
            int backTurns = (n / 2) - (p / 2);

            return Math.Min(frontTurns, backTurns);
        }
    }
}
