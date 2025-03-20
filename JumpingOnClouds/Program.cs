using System.Collections.Specialized;

namespace JumpingOnClouds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JumpingOnClouds(new List<int>() { 0, 1, 0, 0, 0, 1, 0 }));
            Console.WriteLine(JumpingOnClouds(new List<int>() { 0, 0, 0, 0, 1, 0 }));

            Console.WriteLine(JumpingOnClouds( [ 0, 0, 1, 0, 0, 1, 1, 0 ], 2));
        }

        static int JumpingOnClouds(List<int> clouds)
        {
            int countJumps = 0;
            int i = 0;

            while (i < clouds.Count - 1)
            {
                if (i + 2 < clouds.Count && clouds[i + 2] == 0)
                {
                    i += 2;
                }
                else
                {
                    i += 1;
                }
                countJumps++;
            }
            

            return countJumps;
        }
        static int JumpingOnClouds(int[] c, int k)
        {
            int e = 100;
            int n = c.Length;
            int i = 0;

            do
            {
                i = (i + k) % n;
                e -= 1 + 2 * c[i];
            } while (i != 0);

            return e;
        }
    }
}
