namespace Pangrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pangrams("The quick brown fox jumps over the lazy dog."));
            Console.WriteLine(Pangrams("The quick brown fox."));
        }

        static string Pangrams(string s)
        {
            HashSet<char> characters = new HashSet<char>();

            foreach (char c in s.ToLower())
            {
                if (char.IsLetter(c))
                    characters.Add(c);
            }

            return characters.Count == 26 ? "pangram" : "not pangram";
        }
    }
}
