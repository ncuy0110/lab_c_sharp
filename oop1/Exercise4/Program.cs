namespace Exercise4
{

    internal partial class Program
    {
        private static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            f1.Input();
            f1.DisplayFraction();

            Fraction f2 = new Fraction();
            f2.Input();
            f2.DisplayFraction();

            f1.Add(f2);
            f1.DisplayFraction();
        }
    }
}