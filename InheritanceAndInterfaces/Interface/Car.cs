namespace InheritanceAndInterfaces.Interface
{
    internal class Car : ISounder
    {
        public void MakeSound()
        {
            Console.WriteLine("HORN SOUND!");
        }

        public void Drive()
        {
            Console.WriteLine("Move forward logic...");
        }
    }
}
