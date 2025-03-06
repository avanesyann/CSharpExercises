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
            return CalculateSalaryAfterTax(BaseSalary + Bonus);
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
            return CalculateSalaryAfterTax(HourlyRate * HoursWorked);
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


        protected double CalculateSalaryAfterTax(double salary)
        {
            double tax = 0;

            if (salary <= 10000) tax = salary * 0.1;
            else if (salary <= 30000) tax = 10000 * (salary - 10000) * 0.15;
            else if (salary <= 60000) tax = 10000 * 0.10 + 20000 * 0.15 + (salary - 30000) * 0.20;
            else tax = 10000 * 0.10 + 20000 * 0.15 + 30000 * 0.20 + (salary - 60000) * 0.25;

            return salary - tax;
        }
    }
}
