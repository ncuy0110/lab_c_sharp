namespace Exercise2
{
    public class Student : Person
    {
        private float gpa = 0.0f;

        public Student(string name) : base(name)
        {
        }

        public Student(string name, int age, float gpa) : base(name, age)
        {
            SetGpa(gpa);
        }

        public Student() : base()
        {
        }

        public void SetGpa(float? gpa)
        {

            if (gpa == null)
            {
                throw new ArgumentException("GPA cannot null");
            }
            if (gpa < 0 || gpa > 4)
            {
                throw new ArgumentException("GPA must be in range [0, 4]");
            }

            this.gpa = (float)gpa;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Enter GPA: ");
            float gpa = 0.0f;
            gpa = Convert.ToSingle(Console.ReadLine());
            SetGpa(gpa);
        }

        public void DisplayStudent()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + $", GPA - {String.Format("{0:0.00}", this.gpa)}";
        }
    }
}