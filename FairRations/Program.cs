namespace FairRations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> loaves = new List<int>() { 4, 5, 6, 7 };
            Console.WriteLine(FairRations(loaves));
        }

        static string FairRations(List<int> b)
        {
            int countLoaves = 0;
            for (int i = 0; i < b.Count - 1; i++)
            {
                if (b[i] % 2 != 0)
                {
                    b[i]++;
                    b[i + 1]++;

                    countLoaves += 2;
                }
            }

            int totalLoaves = b.Sum();

            return totalLoaves % 2 == 0 ? countLoaves.ToString() : "NO";
        }
    }
}
