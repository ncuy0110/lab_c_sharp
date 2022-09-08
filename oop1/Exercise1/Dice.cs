namespace Exercise1
{
    public class Dice
    {
        private int sides;

        public void setSides(int sides)
        {
            if (sides < 1 || sides > 6)
            {
                throw new ArgumentException("Sides must be in range [1, 6]");
            }

            this.sides = sides;
        }

        public int roll()
        {
            Random rd = new Random();

            return rd.Next(1, this.sides + 1);
        }
    }
}