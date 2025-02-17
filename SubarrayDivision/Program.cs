namespace SubarrayDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> chocolate = new List<int>() { 1, 2, 1, 3, 2 };
            int bars = 2;
            int sum = 3;

            Console.WriteLine(Birthday(chocolate, sum, bars));
        }
        static int Birthday(List<int> chocolatePieces, int day, int month)
        {
            int count = 0;
            int sum = 0;

            for (int i = 0; i < chocolatePieces.Count; i++)
            {
                sum += chocolatePieces[i];

                if (i >= month - 1)
                {
                    if (sum == day)
                        count++;

                    sum -= chocolatePieces[i - (month - 1)];
                }
            }

            return count;
        }
    }
}
