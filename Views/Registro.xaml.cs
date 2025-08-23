using Microsoft.Maui.Controls;
using System;

namespace TreeHouse.Views
{
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void OnRegistrateClicked(object sender, EventArgs e)
        {
            string nombre = nombreEntry.Text?.Trim() ?? string.Empty;
            string apellido = apellidoEntry.Text?.Trim() ?? string.Empty;
            string correo = correoEntry.Text?.Trim() ?? string.Empty;
            string contraseña = contraseñaEntry.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            // Simulación de registro (luego lógica real)
            Console.WriteLine($"Registro: {nombre}, {apellido}, {correo}, {contraseña}");

            DisplayAlert("Exito", "Tu cuenta ha sido creada.", "OK");
        }

            private async void OnLoginTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}

