using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Correios;

namespace MelhorAmigo.Paginas.formulario
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cachorro : ContentPage
    {
        public Cachorro()
        {
            InitializeComponent();
        }
        private void BuscaCep(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CEP.Text))
                DisplayAlert("Atenção", " O campo de CEP esta vazio ", "OK");
            else
            {
                try
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(CEP.Text);

                    if (retorno is null)
                    {
                        DisplayAlert("Atenção", " O campo de CEP esta vazio ", "OK");
                        return;
                    }
                    ENDERECO.Text = retorno.end;
                    CEP.Text = retorno.cep;
                    BAIRRO.Text = retorno.bairro;
                }
                catch
                {
                    DisplayAlert("Atenção", " O campo de CEP esta vazio ", "OK");
                }
            }
        }
    }
}