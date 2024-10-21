using System;
using EscapeTheMatrix.Interfaces;

namespace EscapeTheMatrix.Rooms
{
    public class Room : IRoom
    {
        public virtual List<IRoom> Rooms { get; set; }
        public virtual string Name { get; set; }

        public Room()
        {
            Rooms = new();
        }
    }
}