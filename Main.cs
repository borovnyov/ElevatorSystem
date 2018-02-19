using System;
using  Gtk;

namespace ElevatorSystem16_02
{
	public class ElevatorSystem16_02
	{
		public static void  Main()
		{
			Application.Init();
			Window mainWin = new Window (" ElevatorSystem ");
			mainWin.Resize(1200, 700);
			Form1StartMenu a1 = new Form1StartMenu ();
			Widget form;
			form = a1.form1();
			mainWin.Add (form);
			mainWin.DeleteEvent += delete_event;

			mainWin.ShowAll ();
			Application.Run ();

		}

		static void delete_event (object obj, DeleteEventArgs args)
		{
			Application.Quit();
		}
	}
}

/*VBox vBox = new VBox ();
			vBox.Show ();
			mainWin.Add (vBox);

 * Button startBut = new Button ();
			mainWin.Add (bBox.);

			bBox.Add (startBut);

			Button button = new Button("Кнопка");

			button.Show();
			Label label = new Label("Elevator Control System");
			label.Show();
			Entry entry = new Entry("Текстовое поле");
			entry.Show();
			vBox.Add(label);
			vBox.Add(entry);
			vBox.Add(button);*/