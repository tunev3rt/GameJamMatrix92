using System;

namespace EscapeTheMatrix.Rooms
{
    public class HallwayRoom : IRoom
    {
        public List<IRoom> Rooms { get; set; }
        public string Name { get; set; }
        public HallwayRoom()
        {
            Rooms = new();
        }


    }
}

