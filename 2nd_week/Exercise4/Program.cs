namespace Exercise4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int guessNumber, guessTime = 1;
            Random rnd = new Random();

            int secretNumber = rnd.Next(1, 101);

            while (guessTime <= 7)
            {
                Console.Write($"{guessTime}. Guess number(1-100): ");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber == secretNumber)
                {
                    Console.Write("Congratulations on winning!");
                    break;
                }
                else
                {
                    guessTime++;

                    if (guessNumber < secretNumber)
                        Console.WriteLine("SMALLER");
                    else
                        Console.WriteLine("BIGGER");
                }
            }

            if (guessTime>7) 
            Console.WriteLine("LOSE!");
        }
    }
}