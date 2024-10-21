using EscapeTheMatrix.Rooms;
using Spectre.Console;

namespace EscapeTheMatrix;

class Program
{
    static void Main(string[] args)
    {

        Day GameDay = new Day("7. Maj, 1999\nHorsens, Danmark");
        Navigation navigationService = new();

        ToiletRoom toiletRoom = new() { Name = "Toilet" };
        BedRoom bedRoom = new() { Name = "Soveværelse" };
        KitchenRoom kitchenRoom = new() { Name = "Køkken" };
        HallwayRoom hallwayRoom = new() { Name = "Gang" };
        LivingRoom livingRoom = new() { Name = "Stue" };

        // Bedroom
        bedRoom.Rooms.Add(toiletRoom);
        bedRoom.Rooms.Add(hallwayRoom);

        // Toilet
        toiletRoom.Rooms.Add(bedRoom);
        toiletRoom.Rooms.Add(hallwayRoom);

        // Hallway
        hallwayRoom.Rooms.Add(toiletRoom);
        hallwayRoom.Rooms.Add(bedRoom);
        hallwayRoom.Rooms.Add(kitchenRoom);
        hallwayRoom.Rooms.Add(livingRoom);

        // Living room
        livingRoom.Rooms.Add(hallwayRoom);
        livingRoom.Rooms.Add(kitchenRoom);

        // Kitchen
        kitchenRoom.Rooms.Add(livingRoom);
        kitchenRoom.Rooms.Add(hallwayRoom);

        Room.CurrentRoom = bedRoom;

        bool isGameRunning = true;
        while (isGameRunning)
        {
            Console.WriteLine(GameDay.GameDay);

            // Navigation
            navigationService.PrintNavigation(Room.CurrentRoom);
            Console.WriteLine($"Du står lige nu i {Room.CurrentRoom.Name}. Vælg et rum at gå til:");
            int i = 1;
            foreach (IRoom room in Room.CurrentRoom.Rooms)
            {
                Console.WriteLine($"{i}) {room.Name}");
                ++i;
            }

            int userInput = int.Parse(Console.ReadLine());
            switch(userInput)
            {
                case 1:
                    navigationService.GoToRoom(toiletRoom);
                    break;

                case 2:
                    navigationService.GoToRoom(hallwayRoom);
                    break;

                default:
                    Console.WriteLine("Du blev bedt om at taste 1 eller 2.");
                    break;
            }
            Console.WriteLine(Room.CurrentRoom.Name);
            isGameRunning = false;
        }

    }

}


