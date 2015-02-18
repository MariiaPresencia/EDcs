using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		//for(int fila=0; fila < 3; fila++)
		//	for(int columna =0; columna < 10 ; columna++){
		//		int index = fila +10 + columna;
		//		Console.WriteLine("index ={0} coluna={1} fila={2}" , index , columna , fila);
		//	}

		//for (int index = 0; index < 30; index++) {
		//	int fila = index / 10;
		//	int columna = index % 10;
		//	Console.WriteLine ("index={0} coluna={1} fila={2}", index, columna, fila);
		//}


		Table table = new Table (9, 10, true);
		table.Visible = true;
	//	table.Attach (button, 0, 1, 0, 1);

		for (uint index = 0; index < 90; index++) {
			uint fila = index / 10;
			uint columna = index % 10;
			Button button = new Button ();
			button.Label = (index + 1).ToString();
			button.Visible = true;
			table.Attach (button, columna , columna + 1 , fila , fila + 1);

			button.Clicked += delegate {
				button.ModifyBg(StateType.Normal, new Gdk.Color(0,255,0));
			};
		}

		vBox.Add (table);


	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
