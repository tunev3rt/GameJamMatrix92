using System;

namespace EscapeTheMatrix
{
    public class Room : IRoom
    {
        public static IRoom? CurrentRoom { get; set; }
        public List<IRoom> Rooms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}