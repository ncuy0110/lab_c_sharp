namespace Exercise2
{
    public class BookYearComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException();
            }

            return x.Year.CompareTo(y.Year);
        }
    }
}