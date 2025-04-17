namespace SeparateNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeparateNumbers("1234");
            SeparateNumbers("91011");
            SeparateNumbers("99100");
        }

        static void SeparateNumbers(string s)
        {
            bool found = false;

            for (int i = 1; i <= s.Length / 2; i++)
            {
                long startingPoint = long.Parse(s.Substring(0, i));
                long current = startingPoint;
                string sequence = "";

                while (sequence.Length < s.Length)
                {
                    sequence += current.ToString();
                    current++;
                }

                if (sequence == s)
                {
                    Console.WriteLine($"YES {startingPoint}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("NO");
            }
        }
    }
}
