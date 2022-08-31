namespace Exercise2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Double a, b, c;

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            Double delta = b * b - 4 * a * c;

            if (delta < 0)
                Console.WriteLine("The equation has no roots");
            else if (delta == 0)
            {
                Double x = -b / (2.0 * a);
                Console.WriteLine("The equation has repeat root is " + x);
            }
            else
            {
                Double x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Double x2 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("The equation has two diff roots is: x1 = " + x1 + ", x2 = " + x2);
            }
        }
    }
}
