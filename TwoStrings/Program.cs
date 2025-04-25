namespace TwoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoStrings("and", "art"));
            Console.WriteLine(TwoStrings("be", "cat"));

            Console.WriteLine(TwoStringsBF("and", "art"));
            Console.WriteLine(TwoStringsBF("be", "cat"));
        }

        static string TwoStrings(string s1, string s2)
        {
            HashSet<char> set1 = new HashSet<char>(s1);

            foreach (char c in s2)
            {
                if (set1.Contains(c))
                    return "YES";
            }
            return "NO";
        }
        static string TwoStringsBF(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j]) return "YES";
                }
            }

            return "NO";
        }
    }
}
