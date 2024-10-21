using System;

namespace EscapeTheMatrix.Rooms
{
    public class BedRoom : IRoom
    {
        public List<IRoom> Rooms { get; set; }
        public string Name { get; set; }

        public BedRoom()
        {
            Rooms = new();
        }

    }
}

