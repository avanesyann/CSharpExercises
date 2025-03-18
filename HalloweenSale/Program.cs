namespace HalloweenSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HowManyGames(20, 3, 6, 70));
        }
        static int HowManyGames(int firstPrice, int changePrice, int lastPrice, int wallet)
        {
            int countGames = 0;
            int currentPrice = firstPrice;

            while (wallet >= currentPrice)
            {
                countGames++;
                wallet -= currentPrice;

                currentPrice = Math.Max(currentPrice - changePrice, lastPrice);
            }

            return countGames;
        }
    }
}
