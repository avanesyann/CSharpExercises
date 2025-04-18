namespace GameOfThrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GameOfThrones("aaabbbb"));
            Console.WriteLine(GameOfThrones("aaabbb"));
            Console.WriteLine(GameOfThrones("cdcdcdcdeeeef"));
        }

        static string GameOfThrones(string s)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            int oddCount = 0;
            
            foreach (var pair in charCount)
            {
                if (pair.Value % 2 != 0)
                    oddCount++;
            }

            return oddCount <= 1 ? "YES" : "NO";
        }
    }
}
