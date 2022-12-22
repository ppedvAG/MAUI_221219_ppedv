namespace MauiKurs.Plattformspezifika;

public partial class Plattformspezifika : ContentPage
{
	public Plattformspezifika()
	{
		InitializeComponent();

		Lbl_Orientation.Text = new DeviceOrientationService().GetOrientation().ToString();
		Lbl_Orientation02.Text = new DeviceOrientationService().GetOrientation().ToString();
	}
}