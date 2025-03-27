namespace ViralAdvertising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Advertising(5));
            Console.WriteLine(Advertising(6));
        }

        static int Advertising(int n)
        {
            int advertiseTo = 5;
            int cumulativeLikes = 0;

            for (int i = 0; i < n; i++)
            {
                int likesToday = advertiseTo / 2;
                cumulativeLikes += likesToday;
                advertiseTo = likesToday * 3;
            }

            return cumulativeLikes;
        }
    }
}
