namespace PcTTLChanger
{
    public class CalculateTime
    {
        public ulong Hours, Minutes, Seconds;
        public CalculateTime(ulong hours, ulong minutes, ulong seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public ulong CalculateInSeconds()
        {
            ulong hours_seconds = (Hours * 60) * 60;
            ulong minutes_seconds = Minutes * 60;
            return hours_seconds + minutes_seconds + Seconds;
        }
    }
}
