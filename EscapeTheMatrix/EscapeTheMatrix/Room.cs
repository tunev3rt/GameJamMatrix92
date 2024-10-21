using System;
namespace EscapeTheMatrix
{
	public class Room
	{
		public static Room? CurrentRoom { get; set; }
		public virtual List<Room>? Rooms { get; }
	}
}

