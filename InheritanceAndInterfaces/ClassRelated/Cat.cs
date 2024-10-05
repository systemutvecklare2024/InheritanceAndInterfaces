namespace InheritanceAndInterfaces.ClassRelated
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: MJAU!!!");
        }

        public void Poop()
        {
            Console.WriteLine("Poop in box...");
        }
    }
}
