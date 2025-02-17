using System.Globalization;

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
            if (chocolatePieces == null || chocolatePieces.Count == 0)
                throw new ArgumentException("The list of numbers cannot be null or empty.");

            if (month <= 0 || month > chocolatePieces.Count)
                throw new ArgumentException("Month value must be greater than 0 and less than or equal to the list size.");

            if (day <= 0)
            {
                throw new ArgumentException("Day value must be positive integer.");
            }

            int count = 0;
            int sum = 0;

            // iterate through the list while maintaining a sliding window of size 'month'
            for (int i = 0; i < chocolatePieces.Count; i++)
            {
                sum += chocolatePieces[i];

                // once we reach the required windows size
                if (i >= month - 1)
                {
                    if (sum == day) // check if sum matches the required value
                        count++;

                    sum -= chocolatePieces[i - (month - 1)];    // slide window forward
                }
            }

            return count;
        }
    }
}
