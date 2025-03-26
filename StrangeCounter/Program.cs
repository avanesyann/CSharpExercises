namespace StrangeCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrangeCounter(4));
        }

        static long StrangeCounter(long t)
        {
            long cycleStart = 1;
            long value = 3;

            while (t >= cycleStart + value)
            {
                cycleStart += value;
                value *= 2;
            }

            return value - (t - cycleStart);
        }
    }
}
