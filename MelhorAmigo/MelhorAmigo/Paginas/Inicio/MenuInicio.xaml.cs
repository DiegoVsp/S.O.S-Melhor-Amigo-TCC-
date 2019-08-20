using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MelhorAmigo.Paginas.Inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuInicio : ContentPage
    {
        public MenuInicio()
        {
            InitializeComponent();
        }
        private void apoie(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Pag.Apoie()) { BarBackgroundColor = Color.Black };
            Navigation.PushAsync(new Pag.Apoie());

        }
        private void adote(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Pag.Adote()) { BarBackgroundColor = Color.Black };
            Navigation.PushAsync(new Pag.Adote());
        }
        private void dep(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Pag.Depoimentos()) { BarBackgroundColor = Color.Black };
            Navigation.PushAsync(new Pag.Depoimentos());
        }
        private void leis(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Pag.Leis()) { BarBackgroundColor = Color.Black };
            Navigation.PushAsync(new Pag.Leis());
        }
        private void tel(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Pag.Telefones()) { BarBackgroundColor = Color.Black };
            Navigation.PushAsync(new Pag.Telefones());
        }
        private void sobre(object sender, EventArgs args)
        {
            // App.Current.MainPage = new NavigationPage(new Pag.Sobre()) { BarBackgroundColor = Color.Black };
            Navigation.PushAsync(new Pag.Sobre());
        }
    }
}