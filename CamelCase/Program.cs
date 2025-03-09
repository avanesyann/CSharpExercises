namespace CamelCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CamelCase("justAWord"));
            Console.WriteLine(CamelCase("someOtherWord"));
            Console.WriteLine(CamelCase("someQuiteLongWord"));
            Console.WriteLine(CamelCase("someQuiteReallyLongWord"));
        }

        static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int countUppercases = 0;
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    countUppercases++;
            }

            return countUppercases + 1;
        }
    }
}
