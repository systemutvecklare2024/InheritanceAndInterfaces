namespace InheritanceAndInterfaces.Decoupling
{
    internal class AccountService
    {
        // List with all the accounts..
        private readonly List<Account> _accounts;

        // The class that handles the load and save of accounts.
        private readonly StorageHandler _storageHandler;


        public AccountService(StorageHandler storage)
        {
            _storageHandler = storage;
            _accounts = new List<Account>();
            CreateAccounts();
        }

        private void CreateAccounts()
        {
            _accounts.Add(new Account { Id = 0, Name = "Bengt", Balance = 0 });
            _accounts.Add(new Account { Id = 1, Name = "Berit", Balance = 0 });
            _accounts.Add(new Account { Id = 2, Name = "Bodil", Balance = 0 });
            _accounts.Add(new Account { Id = 3, Name = "Benny", Balance = 0 });
        }

        public void ShowAllAccounts()
        {
            foreach (var account in _accounts)
            {
                Console.WriteLine(account);
            }
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            _accounts.Remove(account);
        }

        public void Save()
        {
            _storageHandler.Save(_accounts);
        }

        public void Load()
        {
            var newAccounts = _storageHandler.Load();
            
            // Bug: Only add accounts not already in _accounts...
            foreach (var account in newAccounts)
            {
                _accounts.Add(account);
            }
        }
    }
}
