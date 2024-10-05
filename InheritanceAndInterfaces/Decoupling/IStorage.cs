namespace InheritanceAndInterfaces.Decoupling
{
    internal interface IStorage
    {
        public void Save(List<Account> accounts);
        public List<Account> Load();
    }
}
