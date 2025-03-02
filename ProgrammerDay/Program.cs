namespace ProgrammerDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DayOfProgrammer(1917));
            Console.WriteLine(DayOfProgrammer(1918));
            Console.WriteLine(DayOfProgrammer(1919));
            Console.WriteLine(DayOfProgrammer(2016));
        }

        static string DayOfProgrammer(int year)
        {
            bool isJulian = (year <= 1917) && (year % 4 == 0);
            bool isGregorian = (year >= 1919) && ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));

            int day = (isJulian || isGregorian) ? 12 : 13;
            if (year == 1918) day = 26;

            return $"{day}.09.{year}";
        }
    }
}
