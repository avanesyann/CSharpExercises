namespace PayrollSystem
{
    public class FullTime : Employee
    {
        public double BaseSalary { get; }
        public double Bonus { get; }

        public FullTime(string name, double salary, double bonus) : base(name)
        {
            BaseSalary = salary;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }
    }
    public class PartTime : Employee
    {
        public double HourlyRate { get; }
        public int HoursWorked { get; }

        public PartTime(string name, double hourlyRate, int hoursWorked) : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
    public abstract class Employee
    {
        public string Name { get; }


        public Employee(string name)
        {
            Name = name;
        }
        public abstract double CalculateSalary();
    }
}
