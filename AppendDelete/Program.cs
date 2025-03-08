namespace AppendDelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppendAndDelete("hackerhappy", "hackerrank", 9)); // test case 1
            Console.WriteLine(AppendAndDelete("ashley", "ash", 2));             // test case 2
            Console.WriteLine(AppendAndDelete("ash", "ashley", 3));             // test case 3
            Console.WriteLine(AppendAndDelete("cort", "mort", 8));              // test case 4
        }

        static string AppendAndDelete(string s, string t, int k)
        {
            int longestCommonPrefix = Math.Min(s.Length, t.Length);

            for (int i = 0; i < longestCommonPrefix; i++)
            {
                if (s[i] != t[i])
                {
                    longestCommonPrefix = i;
                    break;
                }
            }

            int toRemove = s.Length - longestCommonPrefix;
            int toAdd = t.Length - longestCommonPrefix;
            int minOperations = toRemove + toAdd;

            if (minOperations > k)
                return "NO";

            return (k - minOperations) % 2 == 0 || k >= s.Length + t.Length ? "YES" : "NO";
        }
    }
}
