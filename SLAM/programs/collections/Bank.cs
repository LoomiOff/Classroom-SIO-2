namespace SLAM.programs.Collections
{
    public class Bank
    {
        #region Attributs

        private string name;
        private List<Account> accounts = new List<Account>();

        #endregion

        public Bank(string name)
        {
            this.name = name;
        }

        #region Getters

        public string GetName() { return name; }

        public int GetSize() { return accounts.Count; }

        public List<Account> GetAccounts() { return accounts; }

        public Account? GetAccount(int accountId)
        {
            foreach (var account in accounts)
                if (account.GetId() == accountId) 
                    return account;

            return null;
        }

        public Account? GetAccount(string accountName)
        {
            foreach (var account in accounts)
                if (account.GetName() == accountName) 
                    return account;

            return null;
        }

        #endregion

        #region Adders

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        #endregion

        #region Removers

        public bool RemoveAccount(Account account)
        {
            return accounts.Remove(account);
        }

        public bool RemoveAccount(string accountName)
        {
            foreach (var account in accounts)
                if (account.GetName() == accountName) 
                    return accounts.Remove(account);

            return false;
        }

        public bool RemoveAccount(int accountId)
        {
            foreach (var account in accounts)
                if (account.GetId() == accountId)
                    return accounts.Remove(account);

            return false;
        }

        #endregion
    }
}
