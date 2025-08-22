using Microsoft.Maui.Controls;
using Microsoft.Extensions.Logging;

namespace TreeHouse;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new NavigationPage(new MainPage()));
	}
}