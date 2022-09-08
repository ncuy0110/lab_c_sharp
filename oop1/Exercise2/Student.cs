namespace Exercise2
{
    public class Student : Person
    {
        private float gpa = 0.0f;

        public float Gpa
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 4)
                {
                    throw new ArgumentException("GPA must be in range [0, 4]");
                }

                gpa = value;

            }
        }

        public Student(string name) : base(name)
        {
        }

        public Student() : base()
        {
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Enter GPA: ");
            float gpa = 0.0f;
            gpa = Convert.ToSingle(Console.ReadLine());
            Gpa = gpa;
        }

        public void DisplayStudent()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $", GPA - {String.Format("{0:0.00}", Gpa)}";
        }
    }
}