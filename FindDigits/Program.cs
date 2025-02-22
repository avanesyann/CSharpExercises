namespace FindDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindDigits(124));
            Console.WriteLine(FindDigits(1012));
            Console.WriteLine(FindDigits(54));
        }

        public static int FindDigits(int n)
        {
            int number = Math.Abs(n);
            int countDivisors = 0;

            while (number > 0)
            {
                int digit = number % 10;
                if (digit != 0 && n % digit == 0)
                    countDivisors++;

                number /= 10;
            }

            return countDivisors;
        }
    }
}
