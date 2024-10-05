using InheritanceAndInterfaces.ClassRelated;
using InheritanceAndInterfaces.Decoupling;
using InheritanceAndInterfaces.Interface;

namespace InheritanceAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class inheritance etc...
            ClassStuff();


            // Interface stuff...
            InterfaceStuff();

            // Decoupling etc...
            DecouplingStuff();
        }

        private static void DecouplingStuff()
        {
            // Use the JsonStorage implementation
            var jsonStore = new JsonStorage("storageFile.json");

            // Use the Supabase implementation (postgresql in the clouds)
            var supaStore = new SupabaseStorage("postgresql://postgres:[YOUR-PASSWORD]@db.[YOUR-APP-ADDRESS].supabase.co:5432/postgres");

            // Use the XmlStorage implementation
            var xmlStore = new XmlStorage("storageFile.xml");


            // Change which store to use... (jsonStore, supaStore, xmlStore)
            var storageHandler = new StorageHandler(supaStore);
            var accountService = new AccountService(storageHandler);

            accountService.Load();

            //accountService.Save();
        }

        private static void InterfaceStuff()
        {
            var interfaceStuff = new InterfaceStuff();
            interfaceStuff.MakeAllTheSounds();
        }

        private static void ClassStuff()
        {
            var inheritance = new Inheritance();
            inheritance.Show();
        }
    }
}
