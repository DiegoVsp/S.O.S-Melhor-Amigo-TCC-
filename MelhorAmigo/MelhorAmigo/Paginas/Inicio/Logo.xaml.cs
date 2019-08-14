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
    public partial class Logo : ContentPage
    {
        public Logo()
        {
            InitializeComponent();
        }
        private void MudarMenu(object sender, EventArgs args)
        {
            App.Current.MainPage = new Inicio.MenuInicio();
        }
    }
}