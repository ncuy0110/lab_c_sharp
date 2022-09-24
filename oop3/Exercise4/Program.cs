using System.Collections;

namespace Exercise4
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList employees = new ArrayList();
            int n;
            Console.Write("Enter number of employees: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int key = 0;
                while (key < 1 || key > 3)
                {
                    Console.WriteLine("Choose type of employee:");
                    Console.WriteLine("1. Scientist.");
                    Console.WriteLine("2. Manager.");
                    Console.WriteLine("3. Research staff.");
                    key = Convert.ToInt32(Console.ReadLine());
                    switch (key)
                    {
                        case 1:
                            Scientist s = new Scientist();
                            s.Input();
                            employees.Add(s);
                            break;
                        case 2:
                            Manager m = new Manager();
                            m.Input();
                            employees.Add(m);
                            break;
                        case 3:
                            ResearchStaff rs = new ResearchStaff();
                            rs.Input();
                            employees.Add(rs);
                            break;
                        default:
                            break;
                    }
                }
            }
            long salaryOfScientists = 0;
            long salaryOfManager = 0;
            long salaryOfResearchStaff = 0;
            foreach (Object obj in employees)
            {
                switch (obj.GetType().Name)
                {
                    case "Scientist":
                        Scientist s = (Scientist)obj;
                        salaryOfScientists += s.GetSalary();
                        Console.WriteLine(s);
                        break;
                    case "Manager":
                        Manager m = (Manager)obj;
                        salaryOfManager += m.GetSalary();
                        Console.WriteLine(m);
                        break;
                    case "ResearchStaff":
                        ResearchStaff rs = (ResearchStaff)obj;
                        salaryOfResearchStaff += rs.GetSalary();
                        Console.WriteLine(rs);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Salary of scientists: " + salaryOfScientists);
            Console.WriteLine("Salary of manager: " + salaryOfManager);
            Console.WriteLine("Salary of research staff: " + salaryOfResearchStaff);
        }
    }
}