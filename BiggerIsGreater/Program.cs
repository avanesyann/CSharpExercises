namespace BiggerIsGreater
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

            return string.Empty;
        }
    }
}
