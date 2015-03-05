using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		this.Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton3Clicked (object sender, EventArgs e)
	{
		int x, y;

		x = Convert.ToInt32 (entry1.Text);
		y = Convert.ToInt32 (entry2.Text);
		int total = x + y;
		string fin = Convert.ToString(total);
		label1.Text = (fin);
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		int x, y;

		x = Convert.ToInt32 (entry1.Text);
		y = Convert.ToInt32 (entry2.Text);
		int total = x - y;
		string fin2 = Convert.ToString(total);
		label1.Text = (fin2);
	}

	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int x, y;

		x = Convert.ToInt32 (entry1.Text);
		y = Convert.ToInt32 (entry2.Text);
		int total = x * y;
		string fin3 = Convert.ToString(total);
		label1.Text = (fin3);

	}
}
