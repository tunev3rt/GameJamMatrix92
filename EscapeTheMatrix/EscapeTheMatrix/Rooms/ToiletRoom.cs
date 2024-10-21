using System;

namespace EscapeTheMatrix.Rooms
{
    public class ToiletRoom : IRoom
    {
        public List<IRoom> Rooms { get; set; }
        public string Name { get; set; }
        public ToiletRoom()
        {
            Rooms = new();
        }

    }
}