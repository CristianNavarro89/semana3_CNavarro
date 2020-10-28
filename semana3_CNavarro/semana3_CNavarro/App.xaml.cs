using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semana3_CNavarro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //habilita la navegacion entre paginas
            MainPage = new NavigationPage (new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
