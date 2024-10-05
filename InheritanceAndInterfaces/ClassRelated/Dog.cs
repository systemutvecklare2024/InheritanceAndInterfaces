namespace InheritanceAndInterfaces.ClassRelated
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}: Woof!!");
        }

        public void PeeOnWall()
        {
            Console.WriteLine("Logic to pee on wall..");
        }
    }
}
