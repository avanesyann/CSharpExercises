namespace GradesTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple test
            StudentGrades grades = new StudentGrades();
            grades[0] = 95;
            grades[1] = 75;
            grades[2] = 60;
            grades[3] = 65;

            Console.WriteLine(grades[0]);
            Console.WriteLine(grades[1]);
            Console.WriteLine(grades[2]);
            Console.WriteLine(grades[3]);
        }
    }
}
