namespace Exercise4
{
    public class Employee
    {
        private string? name;
        private int yearOfBirth;
        private string? certificate;

        public Employee()
        {
            Name = "Empty name";
            YearOfBirth = 2000;
        }
        public Employee(string? name, int yearOfBirth, string? certificate)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            Certificate = certificate;
        }
        public string? Name { get { return name; } set { name = value; } }
        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        public string? Certificate { get { return certificate; } set { certificate = value; } }

        public virtual int GetSalary() => 0;
        public virtual void Input()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Year of birth: ");
            YearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Certificate: ");
            Certificate = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Year of birth: {YearOfBirth}, Certificate: {Certificate}, Salary: {GetSalary()}";
        }
    }
}