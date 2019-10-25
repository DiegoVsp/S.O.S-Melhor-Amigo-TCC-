using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MelhorAmigo.Modelo;


namespace MelhorAmigo.Paginas.Pag
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Telefones : ContentPage
    {
        public Telefones()
        {
            InitializeComponent();

            List<Tel> Lista = new List<Tel>();
            Lista.Add(new Tel() { Nome = "Ouvidoria Animal" , Phone= "(16) 3303-3115 (7h às 13h)" });
            Lista.Add(new Tel() { Nome = "Coleta de Animais Mortos", Phone = "(16) 99750-4793" });
            Lista.Add(new Tel() { Nome = "Animais Silvestres", Phone = "0800-740-0440" });
            Lista.Add(new Tel() { Nome = "Guarda Municipal", Phone = "(16) 3335-2370" });
            Lista.Add(new Tel() { Nome = "Feira de Adoção ", Phone = "(16) 3301-1800" });

            ListaTelefones.ItemsSource = Lista;


        }
        

        //private async void Selecionado(object senders, SelectedItemChangedEventArgs e)
        //{
        //    Tel tel = e.SelectedItem as Tel;
        //    if(tel != null)
        //    {
        //        await DisplayAlert("Informações de Contato", $"{tel.Nome}", "OK");
        //    }
        //}
    }
}