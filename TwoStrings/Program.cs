namespace TwoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoStrings("and", "art"));
            Console.WriteLine(TwoStrings("be", "cat"));
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
    }
}
