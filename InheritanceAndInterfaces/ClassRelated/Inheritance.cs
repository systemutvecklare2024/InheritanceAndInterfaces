namespace InheritanceAndInterfaces.ClassRelated
{
    internal class Inheritance
    {
        List<Animal> _animals = new();

        public void Show()
        {
            var lotus = new Dog("Lotus");
            _animals.Add(lotus);

            var whiskers = new Cat("Whiskers"); ;
            _animals.Add(whiskers);

            foreach (var animal in _animals)
            {
                animal.MakeSound();
            }
        }
    }
}
