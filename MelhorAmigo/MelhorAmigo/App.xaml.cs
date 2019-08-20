using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MelhorAmigo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Paginas.Inicio.MenuInicio()) { BarBackgroundColor = Color.FromHex("#d72234") }; //Colocado para usar Navigation / Color.FromHex para usar cores Hexa
            // { BarBackgroundColor = Color.Black } para mudar cor barra navegação
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
