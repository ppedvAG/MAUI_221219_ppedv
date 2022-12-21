namespace MauiKurs;

public partial class Resources_Styles : ContentPage
{
	public Resources_Styles()
	{
		InitializeComponent();
	}

    private void Btn_ChangeColor_Clicked(object sender, EventArgs e)
    {
        //Codeseitiger Zugriff auf Ressource
        this.Resources["Blue300Accent"] = Colors.Red;
    }
}