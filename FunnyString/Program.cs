namespace FunnyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FunnyString("lmnop"));
            Console.WriteLine(FunnyString("acxz"));
            Console.WriteLine(FunnyString("bcxz"));
        }

        static string FunnyString(string s)
        {
            bool isFunny = true;

            char[] straight = s.ToCharArray();
            char[] reversed = s.ToCharArray();
            Array.Reverse(reversed);

            for (int i = 1; i < straight.Length; i++)
            {
                int originalDiff = Math.Abs(straight[i] - straight[i - 1]);
                int reversedDiff = Math.Abs(reversed[i] - reversed[i - 1]);

                if (originalDiff != reversedDiff)
                    return "Not Funny";
            }

            return "Funny";
        }
    }
}
