using System;
using Gtk;

namespace ElevatorSystem16_02
{
	public class Form1StartMenu : Box
	{
		public Widget form1()
		{
			VBox vbox;
			HBox hbox;
			Button button;
			Label lable1;
			Label lable2;
			Entry entry1;
			Entry entry2;

			vbox = new VBox (false, 2);
			button = new Button ("Start");
			lable1 = new Label (" number of floors ");
			lable2 = new Label (" number of pessengers ");
			entry1 = new Entry (" 2 ");
			entry2 = new Entry (" 0 ");
			hbox = new HBox ();
			hbox.PackStart(button, true, false, 0);
			vbox.PackStart(hbox, false, true, 0);
			vbox.Show ();
			hbox = new HBox ();
			hbox.PackStart(entry1, true, false, 0);
			hbox.PackStart(lable1, true, false, 0);
			vbox.PackStart(hbox, false, true, 0);
			vbox.Show ();
			hbox = new HBox ();
			hbox.PackStart(entry2, true, false, 0);
			hbox.PackStart(lable2, true, false, 0);
			vbox.PackStart(hbox, false, true, 0);
			vbox.Show ();

			button.Clicked += startCallBack;
			return vbox;

		}

		static void startCallBack(object obj, EventArgs  args )
		{
			
			Console.WriteLine("Hello again - cool button was pressed");
		}




	}



}

