namespace Exercise2
{
    public class Person
    {
        public Person() { }
        public Person(string name) => SetName(name);

        public Person(string name, int age)
        {
            SetName(name);
            this.age = age;
        }

        private string? name;
        private int age = 0;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }

        public string? GetName() => this.name;
        public void SetName(string? name)
        {
            if (name == null)
            {
                throw new ArgumentException("Name cannot be null");
            }
            if (name.Length < 8)
            {
                throw new ArgumentException("Name must be more than 8 characters!");
            }

            this.name = name;
        }

        public void DisplayPerson()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Person: name - {this.name}, age - {this.age}";
        }

        public virtual void Input()
        {
            Console.Write("\nEnter name: ");
            SetName(Console.ReadLine());

            Console.Write("Enter age: ");
            this.age = Convert.ToInt32(Console.ReadLine());
        }
    }
}