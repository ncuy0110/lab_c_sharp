namespace Exercise4
{
    public class Manager : Employee
    {
        private int workingDaysPerMonth;
        public Manager() : base() { }

        public Manager(
            string? name,
            int yearOfBirth,
            string? certificate,
            string? position,
            int workingDaysPerMonth,
            int salaryScale) : base(name, yearOfBirth, certificate)
        {
            Position = position;
            WorkingDaysPerMonth = workingDaysPerMonth;
            SalaryScale = salaryScale;
        }

        public string? Position { get; set; }
        public int WorkingDaysPerMonth
        {
            get { return workingDaysPerMonth; }
            set
            {
                if (value < 0 || value > 31)
                {
                    throw new Exception("Invalid working days!");
                }
                workingDaysPerMonth = value;
            }
        }

        public int SalaryScale { get; set; }

        public override int GetSalary()
        {
            return WorkingDaysPerMonth * SalaryScale;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Position: ");
            Position = Console.ReadLine();

            Console.Write("Working days in the month: ");
            WorkingDaysPerMonth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Salary Scale: ");
            SalaryScale = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Position: {Position}, "
            + $"Working days in the month: {WorkingDaysPerMonth}, Salary scale: {SalaryScale}";
        }
    }
}