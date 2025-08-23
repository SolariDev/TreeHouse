using Microsoft.Maui.Controls;

namespace TreeHouse.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(Object sender, EventArgs e)
        {
            await DisplayAlert("Login", "Función de Login aún no implementada", "OK");
        }
    }
}