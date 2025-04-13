namespace KaprekarNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaprekar(1, 100);
        }

        static void Kaprekar(int p, int q)
        {
            List<int> kaprekars = new List<int>();
            int countKaprekar = 0;

            for (int i = p; i <= q; i++)
            {
                long square = (long)i * i;
                string squareStr = square.ToString();
                int d = i.ToString().Length;

                string leftStr = squareStr.Substring(0, squareStr.Length - d);
                string rightStr = squareStr.Substring(squareStr.Length - d);

                int left = string.IsNullOrEmpty(leftStr) ? 0 : int.Parse(leftStr);
                int right = int.Parse(rightStr);

                if (i == left + right)
                {
                    kaprekars.Add(i);
                    countKaprekar++;
                }
            }
            if (countKaprekar == 0)
                Console.WriteLine("Invalid Range");
            else
                Console.WriteLine(string.Join(" ", kaprekars));
        }
    }
}
