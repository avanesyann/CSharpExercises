namespace LibraryFine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LibraryFine(14, 7, 2018, 5, 7, 2018));
            Console.WriteLine(LibraryFine(02, 02, 2025, 01, 02, 2025));
        }

        static int LibraryFine(int returnedDay, int returnedMonth, int returnedYear, int dueDay, int dueMonth, int dueYear)
        {
            if (returnedYear < dueYear) return 0;
            if (returnedYear > dueYear) return 10000;

            if (returnedMonth < dueMonth) return 0;
            if (returnedMonth > dueMonth) return 500 * (returnedMonth - dueMonth);

            if (returnedDay <= dueDay) return 0;

            return 15 * (returnedDay - dueDay);
        }
    }
}
