namespace InheritanceAndInterfaces.Decoupling
{
    internal class StorageHandler
    {
        // The actual storage implementation
        private readonly IStorage _storage;

        public StorageHandler(IStorage storage)
        {
            _storage = storage;
        }

        public void Save(List<Account> accounts)
        {
            _storage.Save(accounts);
        }

        public List<Account> Load()
        {
            return _storage.Load();
        }
    }
}
