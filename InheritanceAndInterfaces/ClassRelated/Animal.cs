namespace InheritanceAndInterfaces.ClassRelated
{
    public abstract class Animal
    {
        public string Name { get; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void MakeSound();
    }
}
