
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.CheckButton checkbutton2;
	
	private global::Gtk.Button button2;
	
	private global::Gtk.Label lblRandomInteger;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.checkbutton2 = new global::Gtk.CheckButton ();
		this.checkbutton2.CanFocus = true;
		this.checkbutton2.Name = "checkbutton2";
		this.checkbutton2.Label = global::Mono.Unix.Catalog.GetString ("checkbutton2");
		this.checkbutton2.DrawIndicator = true;
		this.checkbutton2.UseUnderline = true;
		this.vbox2.Add (this.checkbutton2);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.checkbutton2]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.vbox2.Add (this.button2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.lblRandomInteger = new global::Gtk.Label ();
		this.lblRandomInteger.Name = "lblRandomInteger";
		this.lblRandomInteger.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.vbox2.Add (this.lblRandomInteger);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lblRandomInteger]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler (this.buttonClicked);
	}
}