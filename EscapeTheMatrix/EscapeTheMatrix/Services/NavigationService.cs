using System;
using System.Windows.Input;
using EscapeTheMatrix.Interfaces;
using EscapeTheMatrix.Rooms;

namespace EscapeTheMatrix.Services
{
    public class NavigationService
    {
        public List<IRoom> PrintNavigation(IRoom room)
        {
            return room.Rooms.ToList();
        }

        public void GoToRoom(IRoom room)
        {
        }
    }
}

