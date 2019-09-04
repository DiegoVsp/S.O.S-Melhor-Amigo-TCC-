using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MelhorAmigo.Paginas.Pag
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }
        private void site(object sender, EventArgs args)
        {            
            Navigation.PushAsync(new Pag.Site());
        }
        private void sos_amigo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pag.sos());
        }
    }
}