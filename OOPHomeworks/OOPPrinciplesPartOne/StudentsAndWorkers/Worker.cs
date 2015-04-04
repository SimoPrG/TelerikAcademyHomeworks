namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private const byte workDaysOfWeek = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, byte workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public byte WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / workDaysOfWeek) / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0, -10} {1, -15} --> Money per hour: {2:C}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
