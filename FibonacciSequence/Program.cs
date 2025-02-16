namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");

            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.WriteLine($"Fibonacci({userInput}) = {Fibonacci(userInput)}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        static long Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
