namespace Exercise3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AccountList al = new AccountList();
            // al.SaveFile();
            al.ShowAccountList();
            al.ReadFile();
            al.ShowAccountList();
        }
    }
}