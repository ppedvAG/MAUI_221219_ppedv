namespace MauiKurs.Navi;

//Anmeldung einer Eigenschaft, welche über die Route befüllt werden kann
[QueryProperty(nameof(Item1), "RouteItem1")]
public partial class RouteTargetPage : ContentPage
{
	public string Item1 { set => Lbl_Show.Text = value; }
	public RouteTargetPage()
	{
		InitializeComponent();
	}
}