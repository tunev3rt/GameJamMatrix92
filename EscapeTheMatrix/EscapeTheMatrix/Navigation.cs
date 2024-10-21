using System;
using System.Windows.Input;
namespace EscapeTheMatrix
{
	public class Navigation
	{
		public Navigation()
		{
		}

		public List<IRoom> PrintNavigation(IRoom room)
		{
			return room.Rooms.ToList();
		}

		public void GoToRoom(IRoom room)
		{
			Room.CurrentRoom = room;
		}
	}
}

