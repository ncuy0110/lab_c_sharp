using System.Collections;
namespace Exercise3
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

        public static ArrayList EnterListStudent(int n)
        {
            ArrayList students = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                students.Add(EnterAStudent(i));
            }
            return students;
        }

        public static void PrintStudentList(ArrayList students)
        {
            foreach (Student s in students) {
                s.Display();
            }
        }
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n = ");
            n = Convert.ToInt32(Console.ReadLine());

            ArrayList students = EnterListStudent(n);

            PrintStudentList(students);
        }
    }
}