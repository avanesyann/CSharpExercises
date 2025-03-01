namespace ChocolateFeast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChocolateFeast(10, 2, 5));    // test 1
            Console.WriteLine(ChocolateFeast(12, 4, 4));    // test 2
            Console.WriteLine(ChocolateFeast(6, 2, 2));     // test 3
        }
        static int ChocolateFeast(int money, int cost, int exchange)
        {
            if (cost > money) return 0;

            int chocolate = money / cost;
            int wrappers = chocolate;

            while (wrappers >= exchange)
            {
                int newChocolate = wrappers / exchange;
                chocolate += newChocolate;
                wrappers = (wrappers % exchange) + newChocolate;
            }

            return chocolate;
        }
    }
}
