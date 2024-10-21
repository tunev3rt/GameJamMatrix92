using System;
namespace EscapeTheMatrix
{
	public class LivingRoom : Room
	{
		public LivingRoom()
        {
            Rooms.Add(new HallwayRoom());
            Rooms.Add(new KitchenRoom());
        }
        public override List<Room>? Rooms { get; }
    }
}

