using System;
namespace EscapeTheMatrix.misc
{
    public class Day
    {
        public string Date { get; set; }
        public static int Counter { get; set; } = 0;

        public Day(string date)
        {
            Date = date;
        }
    }
}

