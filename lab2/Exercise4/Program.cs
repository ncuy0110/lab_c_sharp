namespace Exercise4
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            AccountList al = new AccountList();
            al.ReadFile();
            al.ShowAccountList();
        }
    }
}