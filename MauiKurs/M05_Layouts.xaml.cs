namespace MauiKurs;

public partial class Layouts : ContentPage
{
	public Layouts()
	{
		InitializeComponent();

        //Zugriff auf AttachedProperty
        Grid.SetRow(Lbl_Grid5, 2);
    }
}