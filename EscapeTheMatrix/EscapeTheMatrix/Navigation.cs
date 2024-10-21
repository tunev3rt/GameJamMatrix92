using System;
using System.Windows.Input;
namespace EscapeTheMatrix
{
	public class Navigation
	{


		public Navigation()
		{
		}
		public List<Room> PrintNavigation(Room room)
		{
			return room.Rooms;
		}
	}
}

