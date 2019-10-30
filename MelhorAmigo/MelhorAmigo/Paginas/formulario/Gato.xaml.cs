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
    public partial class Gato : ContentPage
    {
        public Gato()
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
                        DisplayAlert("Atenção", " CEP NÃO ENCONTRADO ", "OK");
                        
                        return;
                    }
                    ENDERECO.Text = retorno.end;                    
                    CEP.Text = retorno.cep;
                    BAIRRO.Text = retorno.bairro;
                }
                catch
                {
                    DisplayAlert("Atenção", " CEP NÃO ENCONTRADO ", "OK");
                }
            }
        }

        public class MaskedBehavior : Behavior<Entry>
        {
            private string _mask = "";
            public string Mask
            {
                get => _mask;
                set
                {
                    _mask = value;
                    SetPositions();
                }
            }

            protected override void OnAttachedTo(Entry entry)
            {
                entry.TextChanged += OnEntryTextChanged;
                base.OnAttachedTo(entry);
            }

            protected override void OnDetachingFrom(Entry entry)
            {
                entry.TextChanged -= OnEntryTextChanged;
                base.OnDetachingFrom(entry);
            }

            IDictionary<int, char> _positions;

            void SetPositions()
            {
                if (string.IsNullOrEmpty(Mask))
                {
                    _positions = null;
                    return;
                }

                var list = new Dictionary<int, char>();
                for (var i = 0; i < Mask.Length; i++)
                    if (Mask[i] != 'X')
                        list.Add(i, Mask[i]);

                _positions = list;
            }

            private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
            {
                var entry = sender as Entry;

                var text = entry.Text;

                if (string.IsNullOrWhiteSpace(text) || _positions == null)
                    return;

                if (text.Length > _mask.Length)
                {
                    entry.Text = text.Remove(text.Length - 1);
                    return;
                }

                foreach (var position in _positions)
                    if (text.Length >= position.Key + 1)
                    {
                        var value = position.Value.ToString();
                        if (text.Substring(position.Key, 1) != value)
                            text = text.Insert(position.Key, value);
                    }

                if (entry.Text != text)
                    entry.Text = text;
            }
        }

    }
}