namespace Exercise1
{
    public class Student
    {
        private string? sid = null;
        private string? name = null;
        private string? department = null;
        private float average;

        public Student() { }

        public Student(string sid, string name, string department, float average)
        {
            SID = sid;
            Name = name;
            Department = department;
            Average = average;
        }

        public string? SID
        {
            get { return sid; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new Exception("Invalid sid!");
                }
                sid = value;
            }
        }

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new Exception("Invalid name!");
                }
                name = value;
            }
        }

        public string? Department
        {
            get
            {
                return department;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new Exception("Invalid department!");
                }
                department = value;
            }
        }

        public float Average
        {
            get
            {
                return average;
            }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new Exception("Invalid average!");
                }
                average = value;
            }
        }

        public override string ToString()
        {
            return $"Student[SID={SID}, name={Name}, department={Department}, average={Average}]";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}