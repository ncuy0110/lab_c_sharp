namespace Exercise1
{
    public class Tester
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n = ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student s = new Student();
                Console.WriteLine($"Student {i}:");
                Console.Write("SID: ");
                s.SID = Console.ReadLine();
                Console.Write("Name: ");
                s.Name = Console.ReadLine();
                Console.Write("Department: ");
                s.Department = Console.ReadLine();
                Console.Write("Average: ");
                s.Average = Convert.ToSingle(Console.ReadLine());
                students.Add(s);
            }

            students.ForEach(s =>
            {
                Console.WriteLine(s);
            });
        }
    }
}