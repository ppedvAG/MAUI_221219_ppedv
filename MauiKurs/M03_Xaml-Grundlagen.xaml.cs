namespace MauiKurs;

public partial class XamlGrundlagen : ContentPage
{
	public XamlGrundlagen()
	{
		InitializeComponent();
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "Button wurde geklickt";

        //Mittels eines DisplayAlerts können kleine (asynkrone) Aussagen und Abfragen an den Benutzer ausgegeben
        if (await DisplayAlert("FRAGE", "Soll was gemacht werden?", "Ja", "Nein"))
        //Verändern der Text-Eigenschaft (angezeigter Text) des Buttons
        {
            (sender as Button).Text = "Button wurde geklickt";
            Lbl_Output.Text = "Button wurde geklickt";
        }
    }

}

