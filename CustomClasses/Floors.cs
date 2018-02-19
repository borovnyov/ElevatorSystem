using System;

namespace ElevatorSystem16_02
{
	public class Floor
	{
		private uint passengerMaxOnFloor = 3;
		private readonly uint floorNumber;

		public Floor (uint floorNumber)
		{			
			this.floorNumber = floorNumber;
		}
	}
}

