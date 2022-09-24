namespace Exercise4
{
    public class ResearchStaff : Employee
    {
        private int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0) throw new Exception("invalid salary!");
                salary = value;
            }
        }
        public ResearchStaff() : base() { }

        public ResearchStaff(
            string? name,
            int yearOfBirth,
            string? certificate,
            int salary)
            : base(name, yearOfBirth, certificate)
        {
            Salary = salary;
        }

        public override int GetSalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
    }
}