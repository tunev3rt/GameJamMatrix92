using EscapeTheMatrix.Interfaces;
using EscapeTheMatrix.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeTheMatrix.Services
{
    public class PromptService
    {
        public string CreatePrompt(string[] choices)
        {
            return AnsiConsole.Prompt<string>(new SelectionPrompt<string>()
                .WrapAround(true)
                .Title("\nVælg en handling (Tryk enter)")
                .AddChoices(choices)
                );
        }

        public string CreatePrompt(IRoom currentRoom)
        {
            List<string> roomList = new();
            foreach (IRoom room in currentRoom.Rooms)
            {
                roomList.Add(room.Name);
            }
            roomList.ToArray();
            return AnsiConsole.Prompt<string>(new SelectionPrompt<string>()
                .WrapAround(true)
                .Title("\nVælg et rum")
                .AddChoices(roomList)
                );
        }
    }
}
