using System.Collections;
namespace Exercise4
{
    class AccountBalanceComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Account? left = x as Account;
            Account? right = y as Account;
            if (left is null || right is null)
            {
                throw new ArgumentException();
            }

            return left.Balance.CompareTo(right.Balance);
        }
    }
}