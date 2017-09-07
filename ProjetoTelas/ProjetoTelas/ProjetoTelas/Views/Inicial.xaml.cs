using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoTelas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage
    {
        public Inicial()
        {
            InitializeComponent();
        }


        public void botaoConsulta_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendarConsulta());
        }

        private void botaoLivro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastrarLivro());
        }

        private void botaoTime_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdicionarTime());
        }

        private void botaoInteresse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrarInteresse());
        }
    }
}