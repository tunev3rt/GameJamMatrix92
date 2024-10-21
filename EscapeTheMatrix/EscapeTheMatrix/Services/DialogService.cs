using Spectre.Console;
using System;
namespace EscapeTheMatrix.Services
{
    public class DialogService
    {
        public DialogService()
        {
        }

        public void UserSay(string message)
        {
            AnsiConsole.Markup($"[yellow]Joakim[/]: {message}\n");
        }

        public void NarratorSay(string message)
        {
            Panel panel = new Panel(message)
                .Padding(new Padding(2, 2))
                .Expand()
                .Border(BoxBorder.Rounded);
            AnsiConsole.Write(new Align(panel, HorizontalAlignment.Center, VerticalAlignment.Middle));
        }

        public void Tip(string message)
        {
            AnsiConsole.Markup($"[lightseagreen]{message}[/]\n");
        }
    }
}

