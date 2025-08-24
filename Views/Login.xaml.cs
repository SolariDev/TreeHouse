using Microsoft.Maui.Controls;

namespace TreeHouse.Views
{    
    public partial class Login : ContentPage
    {
        private bool isPasswordHidden = true;
        public Login()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Principal());
        }

        private void OnTogglePasswordClicked(object sender, EventArgs e)
        {
            isPasswordHidden = !isPasswordHidden;
            contraseñaEntry.IsPassword = isPasswordHidden;
            togglePasswordButton.Source = isPasswordHidden ? "eye_closed.png" : "eye.png";
        }
    }
}