namespace TreeHouse;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnRegisterClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Registro", "Pantalla en construcción", "OK");
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Inicio de sesión", "Pantalla en construcción", "OK");
	}
}

