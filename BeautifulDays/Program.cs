using System.Diagnostics.CodeAnalysis;

namespace BeautifulDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BeautifulDays(20, 23, 6));
        }

        static int BeautifulDays(int i, int j, int k)
        {
            if (k == 0) throw new ArgumentException("k cannot be zero.");

            int beautifulDays = 0;
            for (int x = i; x <= j; x++)
            {
                int difference = x - ReverseInt(x);
                if (difference % k == 0) beautifulDays++;
            }

            return beautifulDays;
        }
        static int ReverseInt(int num)
        {
            int reversed = 0;
            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }
            return reversed;
        }
    }
}
