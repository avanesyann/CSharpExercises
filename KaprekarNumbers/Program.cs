namespace KaprekarNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaprekar(10, 100);
        }

        static void Kaprekar(int p, int q)
        {
            for (int i = p; i <= q; i++)
            {
                string iString = i.ToString();
                int left = int.Parse(iString.Substring(0, iString.Length / 2));
                int right = int.Parse(iString.Substring(iString.Length / 2, iString.Length));

                Console.WriteLine(left + " | " + right);
            }
        }
    }
}
