namespace InheritanceAndInterfaces.Interface
{
    internal class AlarmClock : ISounder
    {
        public void MakeSound()
        {
            Console.WriteLine("BEEP");
        }

        public void SetAlarmTime(string time)
        {
            Console.WriteLine($"Setting alarm clock to make sound at {time}");
        }
    }
}
