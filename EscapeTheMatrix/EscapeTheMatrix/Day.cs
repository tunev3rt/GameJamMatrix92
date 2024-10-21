using System;
namespace EscapeTheMatrix
{
	public class Day
	{
		public string GameDay { get; set; }
		public static int Counter { get; set; } = 0;

		public Day(string gameDay)
		{
			GameDay = gameDay;
		}
	}
}

