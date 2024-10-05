using System.Xml.Serialization;

namespace InheritanceAndInterfaces.Decoupling
{
    internal class XmlStorage : IStorage
    {
        public string Path { get; set; }
        public XmlStorage(string path) {
            Path = path;
        }
        public List<Account> Load()
        {
            // all the logic to deserialize the data...
            Console.WriteLine("Loaded data from Xml");
            return new List<Account>(); // Just to avoid compile error
        }

        public void Save(List<Account> accounts)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Account));
            // All the logic to serialize the list of accounts....
            Console.WriteLine("Accounts are being written to XML");
        }
    }
}
