namespace Exercise1
{
    public class Dice
    {
        private int sides;

        public int Sides
        {
            get { return sides; }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Sides must be in range [2, 6]");
                }

                sides = value;
            }
        }
        public int roll()
        {
            Random rd = new Random();

            return rd.Next(2, Sides + 1);
        }
    }
}