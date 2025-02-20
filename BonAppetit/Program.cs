namespace BonAppetit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple test

            List<int> bill = new List<int>() { 3, 10, 2, 9 };
            int annaDidntEat = 1;
            int charged = 7;

            BonAppetit(bill, annaDidntEat, charged);
        }

        static void BonAppetit(List<int> bill, int skippedItemIndex, int chargedAmount)
        {
            int totalCost = bill.Sum();
            int actualCharge = (totalCost - bill[skippedItemIndex]) / 2;

            if (chargedAmount == actualCharge)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(chargedAmount - actualCharge);
        }
    }
}
