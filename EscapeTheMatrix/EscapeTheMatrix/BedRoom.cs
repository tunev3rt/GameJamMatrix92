using System;
namespace EscapeTheMatrix
{
	public class BedRoom : Room
	{
		public BedRoom()
        {
            Rooms.Add(new HallwayRoom());
        }
        public override List<Room>? Rooms { get; }
    }
}

