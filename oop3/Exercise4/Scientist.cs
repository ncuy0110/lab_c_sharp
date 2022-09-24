namespace Exercise4
{
    public class Scientist : Manager
    {
        public int ArticlesPublic { get; set; }

        public Scientist() : base() { }

        public Scientist(
            string? name,
            int yearOfBirth,
            string? certificate,
            string? position,
            int workingDaysPerMonth,
            int salaryScale,
            int articlesPublic
        ) : base(name, yearOfBirth, certificate, position, workingDaysPerMonth, salaryScale)
        {
            ArticlesPublic = articlesPublic;
        }

        public override void Input()
        {
            base.Input();

            Console.Write("Number of articles public: ");
            ArticlesPublic = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $", Articles public: {ArticlesPublic}";
        }
    }
}