namespace Exercise3
{
    public class Student: People
    {
        private string? sid = null;
        private string? department = null;
        private float average;

        public Student() { }

        public Student(string sid, string name, string department, float average)
        {
            SetSID(sid);
            SetName(name);
            SetDepartment(department);
            SetAverage(average);
        }

        public string? GetSID() => sid;
        public void SetSID(string? sid_)
        {
            if (sid_ == null || sid_.Equals(""))
            {
                throw new Exception("Invalid sid!");
            }
            this.sid = sid_;
        }


        public string? GetDepartment() => department;

        public void SetDepartment(string? department_)
        {
            if (department_ == null || department_.Equals(""))
            {
                throw new Exception("Invalid department!");
            }

            this.department = department_;
        }

        public float GetAverage() => average;

        public void SetAverage(float average)
        {
            if (average < 0 || average > 10)
            {
                throw new System.Exception("Invalid average!");
            }
            this.average = average;
        }

        public override string ToString()
        {
            return $"Student[SID={GetSID()}, name={GetName()}, department={GetDepartment()}, average={GetAverage()}]";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}