using System;
using Gtk; 
namespace ElevatorSystem16_02
{
	public class Elevatorsystem
	{
		private readonly int maxWeight;  // about Passengers
		private uint currentSummWeight; // about Passengers
			
		private uint currentFloor;  
		private bool direction; // true - up


		public Elevatorsystem ()
		{
			maxWeight = 1000;
			currentSummWeight  = 0;
			currentFloor = 1;  
			direction = true; 								
		}


		 

	}
}

