namespace GoogleMap;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        this.layer.UrlTemplate = "https://mt0.google.com/vt/lyrs=y&x={x}&y={y}&z={z}";
    }
}