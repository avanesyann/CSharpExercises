using System.Numerics;

namespace ExtraLongFactorials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial(60);
        }

        static void Factorial(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }
            if (n < 0)
            {
                Console.WriteLine("Factorial is undefined for negative numbers.");
                return;
            }

            BigInteger factorial = BigInteger.One;

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
