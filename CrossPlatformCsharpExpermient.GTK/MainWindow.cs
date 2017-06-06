using System;
using Gtk;
using CrossPlatformCsharpExperiment.Platform;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void buttonClicked (object sender, EventArgs e)
	{
		lblRandomInteger.Text = "Random number: " + RandomGenerator.RandomInteger ().ToString ("F0");
	}
}
