namespace InheritanceAndInterfaces.Interface
{
    internal class InterfaceStuff
    {
        List<ISounder> stuffThatMakesSound = new List<ISounder>();

        public void MakeAllTheSounds()
        {
            stuffThatMakesSound.Add(new Car());
            stuffThatMakesSound.Add(new Spotify());
            stuffThatMakesSound.Add(new AlarmClock());


            foreach (var sound in stuffThatMakesSound)
            {
                sound.MakeSound();
            }
        }
    }
}
