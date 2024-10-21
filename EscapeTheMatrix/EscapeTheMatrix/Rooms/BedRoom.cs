using System;
using EscapeTheMatrix.Interfaces;

namespace EscapeTheMatrix.Rooms
{
    public class BedRoom : Room
    {
        public override List<IRoom> Rooms { get; set; }
        public override string Name { get => base.Name; set => base.Name = value; }

        public BedRoom()
        {
            Rooms = new();
        }

    }
}

