namespace RepeatedString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "a";

            Console.WriteLine(RepeatedString(test, 1000000000000));
        }

        static long RepeatedString(string s, long n)
        {
            long fullReps = n / s.Length;
            long remaining = n % s.Length;

            int countFullA = s.Count(x => x == 'a');
            int countRemA = s[..(int)remaining].Count(x => x == 'a');

            return fullReps * countFullA + countRemA;
        }
    }
}
