using Microsoft.Maui.Controls;
using System;

namespace TreeHouse.Views
{
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private async void OnNuevoContratoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NuevoContrato());
        }

        private async void OnHistorialClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Historial", "Vení más tarde", "OK");
        }
    }
}