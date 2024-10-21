using System;

namespace EscapeTheMatrix.Rooms
{
    public class KitchenRoom : IRoom
    {
        public List<IRoom> Rooms { get; set; }
        public string Name { get; set; }
        public KitchenRoom()
        {
            Rooms = new();
        }
    }
}

