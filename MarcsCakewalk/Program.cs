namespace MarcsCakewalk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> calorie = new List<int>() { 15, 7, 9, 19};
            Console.WriteLine(Cakewalk(calorie));
        }

        static long Cakewalk(List<int> calorie)
        {
            long totalCalories = 0;
            calorie.Sort((a, b) => b.CompareTo(a));

            for (int i = 0; i < calorie.Count; i++)
            {
                totalCalories += (long) Math.Pow(2, i) * calorie[i];
            }

            return totalCalories;
        }
    }
}
