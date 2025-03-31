using System.ComponentModel.DataAnnotations;

namespace TwoCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Alternate("abaacdabd"));
        }

        static int Alternate(string s)
        {
            HashSet<char> uniques = new HashSet<char>(s);
            List<char> uniqueChars = uniques.ToList();

            List<(char, char)> charPairs = new List<(char, char)>();

            for (int i = 0; i < uniques.Count; i++)
            {
                for (int j = i + 1; j < uniques.Count; j++)
                {
                    charPairs.Add((uniqueChars[i], uniqueChars[j]));
                }
            }

            int maxLength = 0;

            foreach (var pair in charPairs)
            {
                char first = pair.Item1;
                char second = pair.Item2;

                string filtered = new string(s.Where(c => c == first || c == second).ToArray());

                if (IsAlternating(filtered))
                    maxLength = Math.Max(maxLength, filtered.Length);

            }

            return maxLength;
        }
        static bool IsAlternating(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                    return false;
            }
            return true;
        }
    }
}
