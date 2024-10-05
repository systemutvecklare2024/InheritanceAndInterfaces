namespace InheritanceAndInterfaces.Interface
{
    internal class Spotify : ISounder
    {
        public void MakeSound()
        {
            Console.WriteLine("Logic to start playing music...");
        }

        public void NextTrack()
        {
            Console.WriteLine("Logic to change to next track");
        }
    }
}
