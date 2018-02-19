using System;
using Gtk;

namespace ElevatorSystem16_02
{
	public class Form1StartMenu  : Box
	{
		public Widget form1()
		{
			VBox vbox;
			Button button;
			Label lable;
			Entry entry1;
			Entry entry2;
			vbox = new VBox ();
			button = new Button ("Start");
			button.Clicked += startCallBack;
			lable = new Label (" Enter number of floors and passangers");
			entry1 = new Entry (" 2 ");
			entry2 = new Entry (" 0 ");
			vbox.Add (button);
			vbox.Add (lable);
			vbox.Add (entry1);
			vbox.Add (entry2);
			vbox.ShowAll ();

			return vbox;

		}

		static void startCallBack(object obj, EventArgs  args )
		{
			
			Console.WriteLine("Hello again - cool button was pressed");
		}




	}



}

