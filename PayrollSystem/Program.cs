namespace PayrollSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new FullTime("Alice", 3000, 500),
                new FullTime("Bob", 4000, 700),
                new PartTime("Charlie", 30, 80),
                new FullTime("Dave", 3500, 400),
                new PartTime("Jessica", 40, 60),
                new PartTime("Carl", 40, 90)
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name}'s Salary: {employee.CalculateSalary()}");
            }
        }
    }
}
