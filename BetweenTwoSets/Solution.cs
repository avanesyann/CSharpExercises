namespace BetweenTwoSets
{
    class Solution
    {
        /// <summary>
        /// Fids the greatest common divisor of two numbers using Euclidean Algorithm.
        /// </summary>
        public static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
        /// <summary>
        /// Finds the least common multiple of two numbers.
        /// </summary>
        public static int LCM(int a, int b) => (a * b) / GCD(a, b);


        /// <summary>
        /// Finds the total numbers that are multiples of LCM(a) and factors of GCD(b).
        /// </summary>
        /// <param name="A">Array of integers</param>
        /// <param name="B">Array of integers</param>
        /// <returns>Count of valid numbers</returns>
        public static int GetTotalX(List<int> A, List<int> B)
        {
            if (A.Count == 0 || B.Count == 0)
                return 0;

            int aLCM = A.Aggregate(LCM);
            int bGCD = B.Aggregate(GCD);
            int count = 0;

            for (int i = aLCM; i <= bGCD; i += aLCM)
            {
                if (bGCD % i == 0)
                    count++;
            }

            return count;
        }
    }
}
