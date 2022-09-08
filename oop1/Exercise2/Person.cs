namespace Exercise2
{
    public class Person
    {
        public Person() { }
        public Person(string name) => Name = name;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string? name = null;
        private int age = 0;

        public int Age { get { return age; } set { age = value; } }

        public string? Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name cannot be null");
                }
                if (value.Length < 8)
                {
                    throw new ArgumentException("Name must be more than 8 characters!");
                }

                name = value;

            }
        }

        public void DisplayPerson()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Person: name - {Name}, age - {Age}";
        }

        public virtual void Input()
        {
            Console.Write("\nEnter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
    }
}