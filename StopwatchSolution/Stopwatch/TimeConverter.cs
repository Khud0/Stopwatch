using System;

namespace Stopwatch
{
    class TimeConverter
    {
        public static string TimeSpanToString(TimeSpan timeSpan)
        {
            string timeString = string.Format( "{0:00}:{1:00}:{2:00}",
                                                timeSpan.Hours,
                                                timeSpan.Minutes,
                                                timeSpan.Seconds );
            return timeString;
        }
    }
}
