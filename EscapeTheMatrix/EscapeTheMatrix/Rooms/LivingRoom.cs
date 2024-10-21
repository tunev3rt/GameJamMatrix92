using System;

namespace EscapeTheMatrix.Rooms
{
    public class LivingRoom : IRoom
    {
        public List<IRoom> Rooms { get; set; }
        public string Name { get; set; }
        public LivingRoom()
        {
            Rooms = new();
        }

    }
}

