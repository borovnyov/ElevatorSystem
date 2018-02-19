using System;
using System.Collections.Generic;

namespace ElevatorSystem16_02
{
	public class FloorList
	{
		private List<Floor> listFloor;
		private uint count = 0;
		public FloorList ()
		{
			listFloor = new List<Floor> ();
		}

		public void Add(Floor floor)
		{
			listFloor.Add (floor);
			++count;
		}


	}
}

