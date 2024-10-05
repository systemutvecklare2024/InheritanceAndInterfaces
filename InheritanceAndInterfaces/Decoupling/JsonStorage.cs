using System.Text.Json;

namespace InheritanceAndInterfaces.Decoupling
{
    internal class JsonStorage : IStorage
    {
        public string Path { get; private set; }

        public JsonStorage(string path)
        {
            Path = path;
        }

        public List<Account> Load()
        {
            var dataString = File.ReadAllText(Path);
            var accounts = JsonSerializer.Deserialize<List<Account>>(dataString);

            if (accounts == null || accounts.Count == 0)
                throw new Exception("No accounts found!");

            Console.WriteLine("Loaded data from xml");

            return accounts;
        }

        public void Save(List<Account> accounts)
        {
            var serializedData = JsonSerializer.Serialize(accounts);
            File.WriteAllText(Path, serializedData);

            Console.WriteLine("Accounts written to json");
        }
    }
}
