namespace Exercise2
{
    public class Tester
    {

        public static Student EnterAStudent(int i)
        {
            Student s = new Student();
            Console.WriteLine($"Student {i}:");
            Console.Write("SID: ");
            s.SetSID(Console.ReadLine());
            Console.Write("Name: ");
            s.SetName(Console.ReadLine());
            Console.Write("Department: ");
            s.SetDepartment(Console.ReadLine());
            Console.Write("Average: ");
            s.SetAverage(Convert.ToSingle(Console.ReadLine()));
            return s;
        }

        public static List<Student> EnterListStudent(int n)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                students.Add(EnterAStudent(i));
            }
            return students;
        }

        public static void PrintStudentList(List<Student> students)
        {
            students.ForEach(s => Console.WriteLine(s));
        }
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n = ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Student> students = EnterListStudent(n);

            PrintStudentList(students);
        }
    }
}