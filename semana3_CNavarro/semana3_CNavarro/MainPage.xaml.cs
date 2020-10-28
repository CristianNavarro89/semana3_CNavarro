using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana3_CNavarro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnAbrirVentanaDos_Clicked(object sender, EventArgs e)

        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (txtUser.Text == "estudiante2020" && txtPass.Text == "uisrael2020")
            {
                await Navigation.PushAsync(new Vista_dos(user, pass));
            }
            else
            {
               await DisplayAlert("Error", "Usuario o Password incorrecto", "Reintentar");

            }
        }
    }
}