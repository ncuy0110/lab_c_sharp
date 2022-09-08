namespace Exercise4
{
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator must be other than 0");
                }
                denominator = value;
            }
        }


        public void Add(Fraction fraction)
        {
            this.Numerator *= fraction.Denominator;
            this.Numerator += this.Denominator * fraction.Numerator;

            this.Denominator *= fraction.Denominator;
        }

        public void Subtract(Fraction fraction)
        {
            this.Numerator *= fraction.Denominator;
            this.Numerator -= this.Denominator * fraction.Numerator;

            this.Denominator *= fraction.Denominator;
        }

        public void Multiply(Fraction fraction)
        {
            this.Numerator *= fraction.Numerator;
            this.Denominator *= fraction.Denominator;
        }

        public void Divide(Fraction fraction)
        {
            this.Numerator *= fraction.Denominator;
            this.Denominator = this.Denominator * fraction.Numerator;
        }

        private void Normalize()
        {
            int gcd = GCD(this.Numerator, this.Denominator);
            this.Numerator /= gcd;
            this.Denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            if (a % b == 0)
                return b;

            return GCD(b, a % b);
        }

        public void DisplayFraction()
        {
            Normalize();
            Console.WriteLine(this.ToString());
        }

        public void DisplayFractionDecimal()
        {
            Normalize();
            Console.WriteLine(String.Format("{0:0.00}", ToDecimal()));
        }

        private float ToDecimal()
        {
            return (float)((Numerator) / Denominator);
        }

        public override string ToString()
        {
            if (Numerator % Denominator == 0) return $"{Numerator}";
            return Numerator + "/" + Denominator;
        }

        public void Input()
        {
            Console.Write("Enter numerator: ");
            Numerator = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                try
                {
                    Console.Write("Enter denominator: ");
                    Denominator = Convert.ToInt32(Console.ReadLine());
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    continue;
                }
                break;
            }
        }
    }
}