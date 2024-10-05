namespace InheritanceAndInterfaces.Decoupling
{
    // Supabase is a cloud hosted postgresql service
    internal class SupabaseStorage : IStorage
    {
        // Uri to connect to the database
        public string Uri { get; set; }

        public SupabaseStorage(string uri)
        {
            Uri = uri;
        }

        public List<Account> Load()
        {
            // All the logic needed to retrieve accounts from the supabase database
            Console.WriteLine("Loaded data from Supabase");
            return new List<Account>(); // Just to avoid compile error
        }

        public void Save(List<Account> accounts)
        {
            Console.WriteLine("Accounts sent to your supabase database...");
            // All the logic needed to save accounts to the supabase database
        }
    }
}
