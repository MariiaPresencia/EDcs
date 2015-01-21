using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		Label label = new Label ("Este lo he añadido a mano");
		label.Visible = true;
		vBox.Add (label);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonAceptarClicked (object sender, EventArgs e)
	{
		LabelSaludo.Text = "Hola " + entryNombre.Text;
	}
}
