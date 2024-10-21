using System;
namespace EscapeTheMatrix
{
	public class KitchenRoom : Room
	{
		public KitchenRoom()
        {
            Rooms.Add(new HallwayRoom());
            Rooms.Add(new LivingRoom());
        }
        public override List<Room>? Rooms { get; }
    }
}

