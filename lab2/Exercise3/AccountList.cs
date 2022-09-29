using System.Collections;

namespace Exercise3
{
    public class AccountList
    {
        private ArrayList accounts = new ArrayList();
        public void NewAccount()
        {
            Account acc = new Account();
            acc.Input();
            accounts.Add(acc);
        }

        public void ShowAccountList()
        {
            foreach (Account acc in accounts)
            {
                acc.Show();
            }
        }

        public async void SaveFile()
        {
            string? filename;
            Console.Write("Enter file name to save account list: ");
            filename = Console.ReadLine();
            if (filename is not null)
            {

                using StreamWriter file = new(filename);

                foreach (Account acc in accounts)
                {
                    await file.WriteLineAsync(acc.ToStringLine());
                }
            }
        }

        public void ReadFile()
        {
            string? filename;
            Console.Write("Enter file name to read account list: ");
            filename = Console.ReadLine();
            if (filename is not null)
            {
                foreach (string line in System.IO.File.ReadLines(filename))
                {
                    accounts.Add(new Account(line));
                }
            }
        }
    }
}