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
    public partial class Adote : ContentPage
    {
        public Adote()
        {
            InitializeComponent();
        }
        
        private void IrParaFormGato(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Paginas.formulario.Gato());
        }
    private void IrParaFormCachorro(object sender, EventArgs args)
    {
        Navigation.PushAsync(new Paginas.formulario.Cachorro());
    }
}
}