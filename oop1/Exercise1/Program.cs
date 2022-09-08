using Exercise1;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Dice dice = new Dice();
        int sides;

        Console.Write("Sides of dice: ");
        sides = Convert.ToInt32(Console.ReadLine());

        try
        {
            dice.setSides(sides);

            Console.WriteLine($"Random sides is {dice.roll()}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}