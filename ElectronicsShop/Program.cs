namespace ElectronicsShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keyboards = new int[] { 40, 50, 60 };
            int[] drives = new int[] { 5, 8, 12 };

            int budget = 60;

            Console.WriteLine("The total: " + GetMoneySpent(keyboards, drives, budget));
        }

        static int GetMoneySpent(int[] keyboards, int[] drives, int budget)
        {
            if (keyboards == null || drives == null || keyboards.Length == 0 || drives.Length == 0)
                return -1;

            Array.Sort(keyboards);
            Array.Sort(drives);

            int maxAffordable = -1;
            int keyboardIndex = keyboards.Length - 1;
            int driveIndex = 0;

            while (keyboardIndex >= 0 && driveIndex < drives.Length)
            {
                int sum = keyboards[keyboardIndex] + drives[driveIndex];

                if (sum > budget)
                {
                    keyboardIndex--;
                }
                else
                {
                    maxAffordable = Math.Max(maxAffordable, sum);
                    driveIndex++;
                }
            }

            return maxAffordable;
        }
    }
}
