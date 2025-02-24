namespace CountingValleys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "UDDDUDUU";
            Console.WriteLine(Valleys(path));
        }

        static int Valleys(string path)
        {
            if (path == null || path.Length == 0)
                return 0;

            int seaLevel = 0;
            int countValleys = 0;

            foreach (char step in path)
            {
                if (step == 'U')
                    seaLevel++;
                else
                    seaLevel--;

                if (seaLevel == 0 && step == 'U')
                    countValleys++;
            }
            return countValleys;
        }
    }
}
