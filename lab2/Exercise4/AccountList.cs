using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace Exercise4
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

        public void SaveFile()
        {
            string? filename;
            Console.Write("Enter file name to save account list: ");
            filename = Console.ReadLine();
            if (filename is not null)
            {
                FileStream fs = new FileStream(filename, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, accounts.Cast<Account>().ToList());
                fs.Close();
            }
        }

        public void ReadFile()
        {
            var list = new List<Account>();
            string? filename;
            Console.Write("Enter file name to read account list: ");
            filename = Console.ReadLine();
            if (filename is not null)
            {
                using (Stream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    list = (List<Account>)bf.Deserialize(fileStream);
                }
                accounts = new ArrayList();
                list.ForEach(acc => accounts.Add(acc));
            }
        }

        public void SortByID()
        {
            accounts.Sort(new AccountIDComparer());
        }

        public void SortByFirstName()
        {
            accounts.Sort(new AccountFistNameComparer());
        }

        public void SortByBalance()
        {
            accounts.Sort(new AccountBalanceComparer());
        }

        public void RemoveAccountByID(string? id)
        {
            Account acc = new Account();
            acc.ID = id;

            ArrayList accCopy = accounts;

            SortByID();
            int position = accounts.BinarySearch(acc, new AccountIDComparer());
            accounts.RemoveAt(position);
        }
    }
}