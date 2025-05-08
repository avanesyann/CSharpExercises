namespace BiggerIsGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testCase1 = "ab";
            string testCase2 = "aa";
            string testCase3 = "hefg";

            Console.WriteLine(BiggerIsGreater(testCase1));
            Console.WriteLine(BiggerIsGreater(testCase2));
            Console.WriteLine(BiggerIsGreater(testCase3));
        }

        static string BiggerIsGreater(string w)
        {
            // You are given a word and need to find the next lexicographically greater permutation of its characters.
            // If no such permutation exists (i.e., the word is the largest possible with those characters), return "no answer".

            // 1. Find the pivot: Find the rightmost character that is smaller than its next character.
            // 2. Find the successor: From the end of the string, find the smallest character that is greater than the pivot, and swap them.
            // 3. Reverse the suffix: Reverse the portion of the string after the pivot's original index.

            // Example:
            // input: "ab"
            // output: "ba"

            // input: "hefg"
            // output: "hegf"

            char[] chars = w.ToCharArray();

            int i = chars.Length - 2;
            while (i >= 0 && chars[i] >= chars[i + 1])
                i--;

            if (i < 0)
                return "no answer";


            int j = chars.Length - 1;
            while (chars[j] <= chars[i])
                j--;


            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;

            Array.Reverse(chars, i + 1, chars.Length - i - 1);

            

            return new string(chars);
        }
    }
}
