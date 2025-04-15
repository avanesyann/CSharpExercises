namespace MarsExploration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MarsExploration("SOSSOT"));
            Console.WriteLine(MarsExploration("SOSSOSSOS"));
        }

        public static int MarsExploration(string s)
        {
            string baseStr = "SOS";
            int repeatCount = s.Length / baseStr.Length;

            string repeated = string.Concat(Enumerable.Repeat(baseStr, repeatCount));

            int changed = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != repeated[i])
                    changed++;
            }

            return changed;
        }
    }
}
