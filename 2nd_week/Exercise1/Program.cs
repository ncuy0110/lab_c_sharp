internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        char operation;

        Console.Write("a = ");
        a = Convert.ToInt32(Console.ReadLine());


        Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("operation = ");
        operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (operation)
        {
            case '+':
                Console.WriteLine(a + " + " + b + " = " + (a + b));
                break;
            case '-':
                Console.WriteLine(a + " - " + b + " = " + (a - b));
                break;
            case '*':
                Console.WriteLine(a + " * " + b + " = " + a * b);
                break;
            case '/':
                if (b == 0)
                    Console.WriteLine("Cannot divided by 0!");
                else
                    Console.WriteLine(a + " / " + b + " = " + a / b);
                break;
            default:
                Console.WriteLine("This operator is invalid!");
                break;
        }
    }
}