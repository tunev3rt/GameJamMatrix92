using EscapeTheMatrix.Interfaces;
using EscapeTheMatrix.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheMatrix.Services
{
    public class RoomService
    {
        public IRoom? CurrentRoom { get; set; }
        public Room Room { get; set; }
        public ToiletRoom ToiletRoom { get; set; }
        public LivingRoom LivingRoom { get; set; }
        public KitchenRoom KitchenRoom { get; set; }
        public BedRoom BedRoom { get; set; }
        public HallwayRoom HallwayRoom { get; set; }

        public void CreateRooms()
        {
            ToiletRoom = new() { Name = "Badeværelse" };
            LivingRoom = new() { Name = "Stue" };
            KitchenRoom = new() { Name = "Køkken" };
            BedRoom = new() { Name = "Soveværelse" };
            HallwayRoom = new() { Name = "Gang" };


            // Add the rooms to the base class list.
            Room = new();
            Room.Rooms.AddRange(new List<Room> { ToiletRoom, LivingRoom, KitchenRoom, BedRoom, HallwayRoom });

        }

        public void AddRoomConnection()
        {
            // Soveværelse
            BedRoom.Rooms.Add(HallwayRoom);
            BedRoom.Rooms.Add(ToiletRoom);

            // Toilet
            ToiletRoom.Rooms.Add(BedRoom);
            ToiletRoom.Rooms.Add(HallwayRoom);

            // Gang
            HallwayRoom.Rooms.Add(BedRoom);
            HallwayRoom.Rooms.Add(ToiletRoom);
            HallwayRoom.Rooms.Add(KitchenRoom);
            HallwayRoom.Rooms.Add(LivingRoom);

            // Stue
            LivingRoom.Rooms.Add(KitchenRoom);
            LivingRoom.Rooms.Add(HallwayRoom);

            // Køkken
            KitchenRoom.Rooms.Add(LivingRoom);
            KitchenRoom.Rooms.Add(HallwayRoom);


        }
    }
}
