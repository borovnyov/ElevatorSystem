using System;

namespace ElevatorSystem16_02
{
	public class Passanger
	{
		private uint appearFloor;
		private uint wieght;
		private uint distFoor;
		private uint currentFloor;

		public Passanger ()
		{
			appearFloor = 0;
			wieght = 80;
			distFoor = 0;
			currentFloor = this.appearFloor;
		}

		public Passanger ( uint appearFloor, uint wieght, uint distFloor )
		{
			this.appearFloor = appearFloor;
			this.wieght = wieght;
			this.distFoor = distFloor;
			currentFloor = this.appearFloor;
		}




	}
}

