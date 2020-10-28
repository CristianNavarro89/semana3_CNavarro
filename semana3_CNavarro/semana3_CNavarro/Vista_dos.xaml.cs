using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3_CNavarro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista_dos : ContentPage
    {
        public Vista_dos(String user, String pass)
        {
            InitializeComponent();
            lbluser.Text = user;
            txtPass.Text = pass;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                var notaSeguimiento1 = Convert.ToDouble(entryNotaSeguimiento1.Text) * 0.3;
                var notaExamen1 = Convert.ToDouble(entryExamen1.Text) * 0.2;
                var notaParcial1 = notaSeguimiento1 + notaExamen1;
                labelNotaParcial1.Text = "Nota Parcial: " + notaParcial1.ToString();

                var notaSeguimiento2 = Convert.ToDouble(entryNotaSeguimiento2.Text) * 0.3;
                var notaExamen2 = Convert.ToDouble(entryExamen2.Text) * 0.2;
                var notaParcial2 = (notaSeguimiento2 + notaExamen2);
                labelNotaParcial2.Text = "Nota Parcial: " + notaParcial2.ToString();

                var notaFinal = notaParcial1 + notaParcial2;
                textnotaFinal.Text = "NOTA FINAL: " + notaFinal;
                if (notaFinal >= 7)
                {
                    textEstado.Text = "APROBADO";

                    string mensaje = "NOTA FINAL: " + notaFinal;
                    //Alerta para usuario
                    DisplayAlert("APROBADO", mensaje, "Gracias");
                }
                else if (notaFinal < 7)
                {
                    textEstado.Text = "REPROBADO";

                    string mensaje = "NOTA FINAL: " + notaFinal;
                    //Alerta para usuario
                    DisplayAlert("REPROBADO", mensaje, "Gracias");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}