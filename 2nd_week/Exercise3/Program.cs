namespace Exercise3
{
    internal class Program
    {

        public static bool checkPrime(int n)
        {
            if (n == 2 || n == 3) return true;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private static void Main(string[] args)
        {
            int n = 0;
            while (n < 2)
            {
                Console.Write("Enter n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            if (checkPrime(n)) {
                Console.WriteLine("N is prime number!");
            } else {
                Console.WriteLine("N is not a prime number!");
            }
        }
    }
}