using System;
namespace EscapeTheMatrix
{
	public class ToiletRoom : Room
	{
		public ToiletRoom()
		{
			Rooms.Add(new HallwayRoom());
			Rooms.Add(new BedRoom());
		}
		public override List<Room>? Rooms { get; }
    }
}

