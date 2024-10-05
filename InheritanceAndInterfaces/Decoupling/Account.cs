namespace InheritanceAndInterfaces.Decoupling
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Balance { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Balance: {Balance}";
        }
    }
}
