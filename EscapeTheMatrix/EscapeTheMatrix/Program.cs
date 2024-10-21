using EscapeTheMatrix.misc;
using EscapeTheMatrix.Rooms;
using EscapeTheMatrix.Services;
using Spectre.Console;

namespace EscapeTheMatrix;

class Program
{
    static void Main(string[] args)
    {

        Day day = new Day("7. Maj, 1999\nHorsens, Danmark");

        // Dependencies
        NavigationService navigationService = new();
        RoomService roomService = new();
        DialogService dialogService = new();
        PromptService promptService = new();

        // Instantiate Room objects & create connections between them.
        roomService.CreateRooms();
        roomService.AddRoomConnection();

        // Set current room
        roomService.CurrentRoom = roomService.BedRoom;

        bool isGameRunning = true;
        while (isGameRunning)
        {
            //Thread.Sleep(300);
            Panel panel = new Panel(day.Date)
                .Padding(new Padding(2, 2))
                .Expand()
                .Border(BoxBorder.Rounded);
            AnsiConsole.Write(new Align(panel, HorizontalAlignment.Center, VerticalAlignment.Middle));

            //Thread.Sleep(3000);

            Console.Clear();

            dialogService.NarratorSay("Et sted i Horsens ligger en dreng ved navn Joakim og sover, alt imens verden som han kender den er sat på pause.");


            //Thread.Sleep(5000);
            Console.Clear();
            dialogService.UserSay("ZZZZzzzZZZZZ");
            //Thread.Sleep(4000);

            dialogService.NarratorSay("Måske du skulle vække ham?");

            string prompt = promptService.CreatePrompt(new[] { "Væk Joakim" });
            if (prompt == "Væk Joakim")
            {
                Console.Clear();
                dialogService.UserSay("...........ZZzzZZ");
                //Thread.Sleep(1000);
                dialogService.NarratorSay("Hmmm.... det virkede ikke helt. Prøv igen.");
            }

            prompt = promptService.CreatePrompt(new[] { "Væk Joakim" });
            if (prompt == "Væk Joakim")
            {
                Console.Clear();
                dialogService.UserSay("*vågner*");
                //Thread.Sleep(1000);
                dialogService.UserSay("Hvad sker der?");
                //Thread.Sleep(1000);
                dialogService.NarratorSay("Det virkede!");
            }
            //Thread.Sleep(3000);
            Console.Clear();
            dialogService.UserSay("Jeg kan lige så godt gå ud og tisse nu hvor jeg er vågen, I guess.");
            //Thread.Sleep(3000);


            prompt = promptService.CreatePrompt(roomService.CurrentRoom);



            isGameRunning = false;
        }

        Console.ReadKey();

    }

}


