namespace StrongPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "#HackerRank";
            Console.WriteLine(MinimumNumber(password));
        }

        static int MinimumNumber(string password)
        {
            bool hasDigit = password.Any(char.IsDigit);
            bool hasLower = password.Any(char.IsLower);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasSpecial = password.Any(c => "!@#$%^&*()-+".Contains(c));

            int missingConditions = 0;
            if (!hasDigit) missingConditions++;
            if (!hasLower) missingConditions++;
            if (!hasUpper) missingConditions++;
            if (!hasSpecial) missingConditions++;

            return Math.Max(missingConditions, 6 - password.Length);
        }
    }
}
