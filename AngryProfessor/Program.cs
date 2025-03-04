namespace AngryProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arrivalTimes = new List<int>() { -1, -3, 4, 2 };
            int threshold = 3;

            Console.WriteLine(AngryProfessor(threshold, arrivalTimes));
        }

        static string AngryProfessor(int threshold, List<int> arrival)
        {
            int countOnTime = 0;

            foreach (int i in arrival)
            {
                if (i <= 0)
                    countOnTime++;
            }

            return countOnTime >= threshold ? "NO" : "YES";


            // LINQ Implementation

            // return arrival.Count(i => i <= 0) >= threshold ? "NO" : "YES";
        }
    }
}
