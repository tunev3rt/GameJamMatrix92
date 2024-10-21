using System;
using EscapeTheMatrix.Interfaces;

namespace EscapeTheMatrix.Rooms
{
    public class LivingRoom : Room
    {
        public override List<IRoom> Rooms { get; set; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public LivingRoom()
        {
            Rooms = new();
        }

    }
}

