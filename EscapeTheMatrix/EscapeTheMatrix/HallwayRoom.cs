using System;
namespace EscapeTheMatrix
{
	public class HallwayRoom : Room
	{
		public HallwayRoom()
		{
			Rooms.Add(new ToiletRoom());
			Rooms.Add(new LivingRoom());
			Rooms.Add(new KitchenRoom());
			Rooms.Add(new BedRoom());
		}
        public override List<Room>? Rooms { get; }
    }
}

